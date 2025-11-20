using AutoMapper;
using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace ERPServer.Application.Features.Depots.CreateDepot;
    internal sealed class CreateDepotCommandHandler(
    IDepotRepository depotRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateDepotCommand, Result<string>>
    {
    //IDepotRepository Depo tablosu ile ilgili tüm veri tabanı işlemlerini yapmak için
    //IUnitOfWork Birden fazla repository işlemini tek transaction’da toplamak için
    //IMapper CreateDepotCommand → Depot entity’sine çevirir

    public async Task<Result<string>> Handle(CreateDepotCommand request, CancellationToken cancellationToken)
    {
        Depot depot = mapper.Map<Depot>(request);
        await depotRepository.AddAsync(depot, cancellationToken); // depot: veritabanına eklenecek entity
        await unitOfWork.SaveChangesAsync(cancellationToken);//Tüm yapılan işlemleri tek seferde veritabanına yazar

        return "Depo başarıyla kaydedildi";
    }
}
