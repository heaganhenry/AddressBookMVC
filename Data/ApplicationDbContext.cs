using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBookMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBookMVC.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Contact> Contacts { get; set; }
	}
}
