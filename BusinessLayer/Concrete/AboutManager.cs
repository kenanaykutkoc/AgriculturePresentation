﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		private readonly IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void Delete(About t)
		{
			throw new NotImplementedException();
		}

		public About GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<About> GetListAll()
		{
			return _aboutDal.GetListAll();
		}

		public void Insert(About t)
		{
			throw new NotImplementedException();
		}

		public void Update(About t)
		{
			throw new NotImplementedException();
		}
	}
}
