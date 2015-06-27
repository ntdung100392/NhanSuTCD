namespace PMNS.Services.Implement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Entities.Models;
    using PMNS.Services.Abstract;
    using PMNS.DAL.Abstract;
    using PMNS.Infranstructures.Implement;

    public class ThanhPhoServices : Services<ThanhPho>, IThanhPhoServices
    {
        public ThanhPhoServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<ThanhPho> GetAllThanhPho()
        {
            List<ThanhPho> listThanhPho = unitOfWork.Repository<ThanhPho>().GetAll().ToList();
            return listThanhPho;
        }
    }
}
