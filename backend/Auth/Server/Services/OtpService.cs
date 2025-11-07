using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Caching.Memory;
using Server.DTOs;

namespace Server.Services
{
    public class OtpService: IOtpService
    {
        private readonly IMemoryCache _cache;

        public OtpService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public string GenerateOtp(int length = 6)
        {
            var random = new Random();
            var otp = new char[length];
            for (int i = 0; i < length; i++)
            {
                otp[i] = (char)('0' + random.Next(0, 10));
            }
            return new string(otp);
        }

        //public void StoreOtp(string userId, string otp)
        //{
        //    _cache.Set(userId, otp, TimeSpan.FromMinutes(5)); // Store OTP for 5 minutes
        //}

        public void StoreOtp(string key, string otp)
        {
            //Console.WriteLine($"Storing OTP for {key} at {DateTime.UtcNow}");
            //Console.WriteLine($"Generated OTP for {key}: {otp}");
            _cache.Set(key, otp, TimeSpan.FromMinutes(5));
        }

        //public bool ValidateOtp(string key, string otp)
        //{
        //    var storedOtp = _cache.Get<string>(key);
        //    Console.WriteLine($"Validating OTP for {key} at {DateTime.UtcNow}, stored: {storedOtp}, provided: {otp}");
        //    return storedOtp != null && storedOtp == otp;
        //}

        public async Task<bool> ValidateOtpAsync(string key, string otp)
        {
            var cachedOtp = _cache.Get<string>(key);
            if (cachedOtp == null)
            {
                Console.WriteLine($"No OTP found in cache for key: {key}");
                return false;
            }
            Console.WriteLine(cachedOtp + " -- " + otp);
            if (cachedOtp == otp)
            {
                //Console.WriteLine($"Validating OTP at {DateTime.UtcNow},provided: {otp}");
                _cache.Remove(key); // Invalidate OTP after successful validation
                return true;
            }
            return false;
        }
    }
}
