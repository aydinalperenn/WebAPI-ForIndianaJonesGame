using IndianaJones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianaJones.DataAccess.Abstract
{
    public interface IIndianaJonesRepository
    {


        // Player için

        List<Player> GetAllPlayers();
        Player GetPlayerById(int id);
        Player CreatePlayer(Player player);
        Player UpdatePlayer(Player player);
        void DeletePlayer(int id);



        // QA için

        List<QA> GetAllQAs();
        QA GetQAById(int id);
        QA CreateQA(QA qA);
        QA UpdateQA(QA qA);
        void DeleteQA(int id);



        // Rewars için

        List<Rewards> GetAllRewards();
        Rewards GetRewardById(int id);
        Rewards CreateReward(Rewards reward);
        Rewards UpdateReward(Rewards reward);
        void DeleteReward(int id);








    }
}
