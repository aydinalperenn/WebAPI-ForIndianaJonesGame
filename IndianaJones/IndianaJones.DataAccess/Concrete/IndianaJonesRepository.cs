using IndianaJones.DataAccess.Abstract;
using IndianaJones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IndianaJones.DataAccess.Concrete
{
    public class IndianaJonesRepository : IIndianaJonesRepository
    {
        public Player CreatePlayer(Player player)
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                playerDbContext.Tbl_Player.Add(player);
                playerDbContext.SaveChanges();
                return player;
            }
        }

        public QA CreateQA(QA qA)
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                playerDbContext.Tbl_QA.Add(qA);
                playerDbContext.SaveChanges();
                return qA;
            }
        }

        public Rewards CreateReward(Rewards reward)
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                playerDbContext.Tbl_Rewards.Add(reward);
                playerDbContext.SaveChanges();
                return reward;
            }
        }

        public void DeletePlayer(int id)
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                var deletedPlayer = GetPlayerById(id);
                playerDbContext.Tbl_Player.Remove(deletedPlayer);
                playerDbContext.SaveChanges();
            }
        }

        public void DeleteQA(int id)
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                var deletedQA = GetQAById(id);
                playerDbContext.Tbl_QA.Remove(deletedQA);
                playerDbContext.SaveChanges();
            }
        }

        public void DeleteReward(int id)
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                var deletedReward = GetRewardById(id);
                playerDbContext.Tbl_Rewards.Remove(deletedReward);
                playerDbContext.SaveChanges();
            }
        }

        public List<Player> GetAllPlayers()
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                return playerDbContext.Tbl_Player.ToList();
            }
        }

        public List<QA> GetAllQAs()
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                return playerDbContext.Tbl_QA.ToList();
            }
        }

        public List<Rewards> GetAllRewards()
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                return playerDbContext.Tbl_Rewards.ToList();
            }
        }

        public Player GetPlayerById(int id)
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                return playerDbContext.Tbl_Player.Find(id);
            }
        }

        public QA GetQAById(int id)
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                return playerDbContext.Tbl_QA.Find(id);
            }
        }

        public Rewards GetRewardById(int id)
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                return playerDbContext.Tbl_Rewards.Find(id);
            }
        }

        public Player UpdatePlayer(Player player)
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                playerDbContext.Tbl_Player.Update(player);
                playerDbContext.SaveChanges();
                return player;
            }
        }

        public QA UpdateQA(QA qA)
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                playerDbContext.Tbl_QA.Update(qA);
                playerDbContext.SaveChanges();
                return qA;
            }
        }

        public Rewards UpdateReward(Rewards reward)
        {
            using (var playerDbContext = new PlayerDbContext())
            {
                playerDbContext.Tbl_Rewards.Update(reward);
                playerDbContext.SaveChanges();
                return reward;
            }
        }
    }
}
