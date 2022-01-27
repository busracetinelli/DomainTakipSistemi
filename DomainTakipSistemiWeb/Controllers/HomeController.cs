using DomainTakipSistemiWeb.DTO;
using DomainTakipSistemiWeb.DTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DomainTakipSistemiWeb.Controllers
{
    public class HomeController : Controller
    {
        public DomainTakipSistemiEntities context { get; set; }

        public HomeController()
        {
            context = new DomainTakipSistemiEntities();
        }

        [HttpGet]
        public ActionResult Index()
        {
            using (context = new DomainTakipSistemiEntities())
            {
                List<ProjeDto> Data;

                Data = (from s in context.DomainKayit
                        select new ProjeDto()
                        {
                            Domain_Adi = s.Domain_Adi,
                            Domain_Bitis_Tarihi = s.Domain_Bitis_Tarihi,
                            Domain_Fiyati = s.Domain_Fiyati,
                            id = s.id,
                            Metin = s.Metin,
                            Proje_Adi = s.Proje_Adi,
                            Proje_Tipleri = s.Proje_Tipleri,
                            SSL = s.SSL,
                            SSL_Bitis_Tarihi = s.SSL_Bitis_Tarihi,
                            SSL_Fiyati = s.SSL_Fiyati,
                            Statik_IP = s.Statik_IP,
                            Statik_IP_Bitis_Tarihi = s.Statik_IP_Bitis_Tarihi,
                            Statik_IP_Fiyati = s.Statik_IP_Fiyati,
                            Sunucu = s.Sunucu,
                            Sunucu_Bitis_Tarihi = s.Sunucu_Bitis_Tarihi,
                            Sunucu_Fiyati = s.Sunucu_Fiyati,
                            Yenileme_Periyodu = s.Yenileme_Periyodu
                        }).ToList();

                indexViewModel indexViewModel = new indexViewModel()
                {
                    ProjeDtos = Data
                };
                return View(indexViewModel);
            }
        }

        [HttpGet]
        public ActionResult Edit(int Id = 0)
        {
            using (context = new DomainTakipSistemiEntities())
            {
                ProjeDto data;

                data = (from s in context.DomainKayit
                        where s.id == Id
                        select new ProjeDto()
                        {
                            Domain_Adi = s.Domain_Adi,
                            Domain_Bitis_Tarihi = s.Domain_Bitis_Tarihi,
                            Domain_Fiyati = s.Domain_Fiyati,
                            id = s.id,
                            Metin = s.Metin,
                            Proje_Adi = s.Proje_Adi,
                            Proje_Tipleri = s.Proje_Tipleri,
                            SSL = s.SSL,
                            SSL_Bitis_Tarihi = s.SSL_Bitis_Tarihi,
                            SSL_Fiyati = s.SSL_Fiyati,
                            Statik_IP = s.Statik_IP,
                            Statik_IP_Bitis_Tarihi = s.Statik_IP_Bitis_Tarihi,
                            Statik_IP_Fiyati = s.Statik_IP_Fiyati,
                            Sunucu = s.Sunucu,
                            Sunucu_Bitis_Tarihi = s.Sunucu_Bitis_Tarihi,
                            Sunucu_Fiyati = s.Sunucu_Fiyati,
                            Yenileme_Periyodu = s.Yenileme_Periyodu

                        }).FirstOrDefault();

                EditViewModel editViewModel = new EditViewModel()
                {
                    ProjeDto = data
                };
                return View(editViewModel);
            }
        }

        [HttpPost]
        public JsonResult Edit(ProjeDto projeDto)
        {

            using (context = new DomainTakipSistemiEntities())
            {
                try
                {
                    DomainKayit domainKayit = context.DomainKayit.Where(x => x.id == projeDto.id).FirstOrDefault();
                    domainKayit.Proje_Adi = projeDto.Proje_Adi;
                    domainKayit.Domain_Bitis_Tarihi = projeDto.Domain_Bitis_Tarihi;
                    domainKayit.Domain_Fiyati = projeDto.Domain_Fiyati;
                    domainKayit.Metin = projeDto.Metin;
                    domainKayit.Proje_Tipleri = projeDto.Proje_Tipleri;
                    domainKayit.SSL = projeDto.SSL;
                    domainKayit.SSL_Bitis_Tarihi = projeDto.SSL_Bitis_Tarihi;
                    domainKayit.SSL_Fiyati = projeDto.SSL_Fiyati;
                    domainKayit.Statik_IP = projeDto.Statik_IP;
                    domainKayit.Statik_IP_Bitis_Tarihi = projeDto.Statik_IP_Bitis_Tarihi;
                    domainKayit.Statik_IP_Fiyati = projeDto.Statik_IP_Fiyati;
                    domainKayit.Sunucu_Fiyati = projeDto.Sunucu_Fiyati;
                    domainKayit.Yenileme_Periyodu = projeDto.Yenileme_Periyodu;
                    domainKayit.Domain_Adi = projeDto.Domain_Adi;
                    domainKayit.Sunucu = projeDto.Sunucu;
                    domainKayit.Sunucu_Bitis_Tarihi = projeDto.Sunucu_Bitis_Tarihi;
                    context.SaveChanges();
                    return Json("Başarılı");
                }
                catch (Exception ex)
                {
                    return Json("Başarısı");
                }
            }

        }


        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public JsonResult Delete(int id)
        {
            using (context = new DomainTakipSistemiEntities())
            {
                try
                {
                    DomainKayit domainKayit = context.DomainKayit.Where(x => x.id == id).FirstOrDefault();
                    context.DomainKayit.Remove(domainKayit);
                    context.SaveChanges();
                    return Json("Silinemedi");
                }
                catch (Exception ex)
                {

                    return Json("Silinemedi");
                }
            }

        }


        [HttpPost]
        public JsonResult Create(ProjeDto projeDto)
        {
            using (context = new DomainTakipSistemiEntities())
            {
                try
                {
                    DomainKayit domainKayit = new DomainKayit()
                    {
                        Proje_Adi = projeDto.Proje_Adi,
                        Domain_Bitis_Tarihi = projeDto.Domain_Bitis_Tarihi,
                        Domain_Fiyati = projeDto.Domain_Fiyati,
                        Metin = projeDto.Metin,
                        Proje_Tipleri = projeDto.Proje_Tipleri,
                        SSL = projeDto.SSL,
                        SSL_Bitis_Tarihi = projeDto.SSL_Bitis_Tarihi,
                        SSL_Fiyati = projeDto.SSL_Fiyati,
                        Statik_IP = projeDto.Statik_IP,
                        Statik_IP_Bitis_Tarihi = projeDto.Statik_IP_Bitis_Tarihi,
                        Statik_IP_Fiyati = projeDto.Statik_IP_Fiyati,
                        Sunucu_Fiyati = projeDto.Sunucu_Fiyati,
                        Yenileme_Periyodu = projeDto.Yenileme_Periyodu,
                        Domain_Adi = projeDto.Domain_Adi,
                        Sunucu = projeDto.Sunucu,
                        Sunucu_Bitis_Tarihi = projeDto.Sunucu_Bitis_Tarihi
                    };
                    context.DomainKayit.Add(domainKayit);
                    context.SaveChanges();
                    return Json("Başarılı");
                }
                catch (Exception ex)
                {
                    return Json("Başarısız");
                }
            }
           
        }


    }
}