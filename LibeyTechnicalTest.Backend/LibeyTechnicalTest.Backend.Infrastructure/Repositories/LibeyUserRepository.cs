using LibeyTechnicalTest.Backend.Domain.Repositories;
using LibeyTechnicalTest.Backend.Domain.Models;
using LibeyTechnicalTest.Backend.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using LibeyTechnicalTest.Backend.Domain.Exceptions;

namespace LibeyTechnicalTest.Backend.Infrastructure.Repositories
{
    public class LibeyUserRepository : ILibeyUserRepository
    {
        private readonly Context context;
        public LibeyUserRepository(Context context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<LibeyUserModel>> Get()
        {
            var libeyUsers = await context.LibeyUsers.Where(x => x.Active).ToListAsync();
            return libeyUsers;
        }
        public async Task<LibeyUserModel> GetByDocumentNumber(string documentNumber)
        {
            var libeyUser = await context.LibeyUsers.FirstOrDefaultAsync(x => x.DocumentNumber == documentNumber && x.Active);
            return libeyUser ?? throw new NotFoundException("No se encontró el usuario");
        }
        public async Task Insert(LibeyUserModel libeyUser)
        {
            await context.LibeyUsers.AddAsync(libeyUser);
            await context.SaveChangesAsync();
        }

        public async Task Update(LibeyUserModel libeyUser)
        {
            var libeyUserModified = await context.LibeyUsers.FirstOrDefaultAsync(x => x.DocumentNumber == libeyUser.DocumentNumber && x.Active) ?? throw new NotFoundException("No se encontró el usuario");
            libeyUserModified.Name = libeyUser.Name;
            libeyUserModified.FathersLastName = libeyUser.FathersLastName;
            libeyUserModified.MothersLastName = libeyUser.FathersLastName;
            libeyUserModified.Address = libeyUser.Address;
            libeyUserModified.UbigeoCode = libeyUser.UbigeoCode;
            libeyUserModified.Phone = libeyUser.Phone;
            libeyUserModified.Email = libeyUser.Email;
            await context.SaveChangesAsync();
        }
        public async Task Delete(string documentNumber)
        {
            var libeyUser = await context.LibeyUsers.FirstOrDefaultAsync(x => x.DocumentNumber == documentNumber && x.Active) ?? throw new NotFoundException("No se encontró el usuario");
            libeyUser.Active = false;
            await context.SaveChangesAsync();
        }
    }
}
