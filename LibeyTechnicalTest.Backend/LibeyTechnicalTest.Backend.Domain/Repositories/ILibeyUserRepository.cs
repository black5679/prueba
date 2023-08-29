using LibeyTechnicalTest.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Domain.Repositories
{
    public interface ILibeyUserRepository
    {
        Task<IEnumerable<LibeyUserModel>> Get();
        Task<LibeyUserModel> GetByDocumentNumber(string documentNumber);
        Task Insert(LibeyUserModel libeyUser);
        Task Update(LibeyUserModel libeyUser);
        Task Delete(string documentNumber);
    }
}
