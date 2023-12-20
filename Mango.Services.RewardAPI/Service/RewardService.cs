using Mango.Services.RewardAPI.Models;
using Microsoft.EntityFrameworkCore;
using Mango.Services.RewardAPI.Data;
using System;
using Mango.Services.RewardAPI.Message;

namespace Mango.Services.RewardAPI.Service
{
    public class RewardService : IRewardService
    {
        private DbContextOptions<ApplicationDBContext> _dbOptions;

        public RewardService(DbContextOptions<ApplicationDBContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }

        public async Task UpdateRewards(RewardsMessage rewardsMessage)
        {
            try
            {
                Rewards rewards = new()
                {
                    OrderId = rewardsMessage.OrderId,
                    RewardsActivity = rewardsMessage.RewardsActivity,
                    UserId = rewardsMessage.UserId,
                    RewardsDate = DateTime.Now
                };
                await using var _db = new ApplicationDBContext(_dbOptions);
                await _db.Rewards.AddAsync(rewards);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
