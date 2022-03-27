
using P4_Z1;

BazaDanych Northwind = new BazaDanych(@"Data Source=DESKTOP-9K2SBT4;Initial Catalog=ZNorthwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


Northwind.DodajWpis();
Northwind.WyswietlDane();

