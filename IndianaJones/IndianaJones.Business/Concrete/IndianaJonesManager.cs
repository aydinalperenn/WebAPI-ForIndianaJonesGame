using IndianaJones.Business.Abstract;
using IndianaJones.DataAccess.Abstract;
using IndianaJones.DataAccess.Concrete;
using IndianaJones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IndianaJones.Business.Concrete
{
    public class IndianaJonesManager : IIndianaJonesService
    {

        private IIndianaJonesRepository _indianaJonesRepository;


        public IndianaJonesManager()
        {
            _indianaJonesRepository = new IndianaJonesRepository();
        }


        public Player CreatePlayer(Player player)
        {
            return _indianaJonesRepository.CreatePlayer(player);
        }

        public QA CreateQA(QA qA)
        {
            return _indianaJonesRepository.CreateQA(qA);
        }

        public Rewards CreateReward(Rewards reward)
        {
            return _indianaJonesRepository.CreateReward(reward);
        }

        public void DeletePlayer(int id)
        {
            _indianaJonesRepository.DeletePlayer(id);
        }

        public void DeleteQA(int id)
        {
            _indianaJonesRepository.DeleteQA(id);
        }

        public void DeleteReward(int id)
        {
            _indianaJonesRepository.DeleteReward(id);
        }

        public List<Player> GetAllPlayers()
        {
            return _indianaJonesRepository.GetAllPlayers();
        }

        public List<QA> GetAllQAs()
        {
            return _indianaJonesRepository.GetAllQAs();
        }

        public List<Rewards> GetAllRewards()
        {
            return _indianaJonesRepository.GetAllRewards();
        }

        public Player GetPlayerById(int id)
        {
            if (id > 0)
            {
                return _indianaJonesRepository.GetPlayerById(id);
            }
            throw new Exception("ID can not be less than 1.");

        }

        public QA GetQAById(int id)
        {
            if (id > 0)
            {
                return _indianaJonesRepository.GetQAById(id);
            }

            throw new Exception("ID can not be less than 1.");
        }

        public Rewards GetRewardById(int id)
        {
            if (id > 0)
            {
                return _indianaJonesRepository.GetRewardById(id);
            }
            throw new Exception("ID can not be less than 1.");
        }

        public Player UpdatePlayer(Player player)
        {
            return _indianaJonesRepository.UpdatePlayer(player);
        }

        public QA UpdateQA(QA qA)
        {
            return _indianaJonesRepository.UpdateQA(qA);
        }

        public Rewards UpdateReward(Rewards reward)
        {
            return _indianaJonesRepository.UpdateReward(reward);
        }
    }
}
