﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}
		public void ContactAdd(Contact contact)
		{
			_contactDal.Add(contact);
		}

		public void ContactDelete(Contact contact)
		{
			_contactDal.Delete(contact);
		}

		public void ContactUpdate(Contact contact)
		{
			_contactDal.Update(contact);
		}

		public List<Contact> GetAll()
		{
			return _contactDal.GetAll();
		}

		public Contact GetByID(int id)
		{
			return _contactDal.Get(x => x.ConID == id);
		}

		public List<Contact> GetContactByID(int id)
		{
			return _contactDal.GetAll(x => x.ConID == id);
		}

		public List<Contact> GetOrderByDate()
		{
			return _contactDal.GetAll().OrderByDescending(z => z.MessageDate).ToList();
		}
	}
}
