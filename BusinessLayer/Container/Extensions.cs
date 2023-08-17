using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Container
{
	public static class Extensions
	{
		public static void ContainerDependencies(this IServiceCollection Services)
		{
			Services.AddScoped<IServiceService, ServiceManager>();
			Services.AddScoped<IServiceDal, EfServiceDal>();
			Services.AddScoped<ITeamService, TeamManager>();
			Services.AddScoped<ITeamDal, EfTeamDal>();
			Services.AddScoped<IAnnouncementService, AnnouncementManager>();
			Services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
			Services.AddScoped<IImageService, ImageManager>();
			Services.AddScoped<IImageDal, EfImageDal>();
			Services.AddScoped<IAddressService, AddressManager>();
			Services.AddScoped<IAddressDal, EfAddressDal>();
			Services.AddScoped<IContactService, ContactManager>();
			Services.AddScoped<IContactDal, EfContactDal>();
			Services.AddScoped<ISocialMediaService, SocialMediaManager>();
			Services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
			Services.AddScoped<IAboutService, AboutManager>();
			Services.AddScoped<IAboutDal, EfAboutDal>();
			Services.AddScoped<IAdminService, AdminManager>();
			Services.AddScoped<IAdminDal, EfAdminDal>();
		}

	}
}
