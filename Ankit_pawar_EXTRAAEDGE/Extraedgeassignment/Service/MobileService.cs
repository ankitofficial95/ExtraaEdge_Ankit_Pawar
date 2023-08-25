using Extraedgeassignment.Model;
using Extraedgeassignment.Repository;

namespace Extraedgeassignment.Service
{
    public class MobileService : IMobileService
    {
        private readonly IMobileRepository repo;
        public MobileService(IMobileRepository repo)
        {
            this.repo = repo;
        }
        public int AddMobile(Mobile mob)
        {
            return repo.AddMobile(mob);
        }

        public int DeleteMobile(int id)
        {
            return repo.DeleteMobile(id);
        }

        public IEnumerable<Mobile> GetAllMobile()
        {
            return repo.GetAllMobile();
        }

        public Mobile GetMobileById(int id)
        {
            return repo.GetMobileById(id);
        }

        public int UpdateMobile(Mobile mob)
        {
            return repo.UpdateMobile(mob);
        }
    }
}
