using BTG.Credit.Ras.Interview.Domain.DataList;

namespace BTG.Credit.Ras.Interview.Data
{
    public class DataListRepository : IDataListRepository
    {
        public IList<ListItem> GetAll()
        {
            return new List<ListItem>{
                new ListItem {
                    Id = 1,
                    Title= "Clientes inativos",
                    Description= "Listagem dos clientes inativos",
                    ReferenceDate= new DateTime(2024,07,01),
                    Customers = new List<Customer> {
                        new Customer{
                            Name = "Jorge",
                            Birthdate= new DateTime(1990,01,25)
                        },
                        new Customer{
                            Name = "Gustavo",
                            Birthdate= new DateTime(2000,02,25)
                        },
                    }
                },
                new ListItem {
                    Id = 2,
                    Title= "Clientes ativos",
                    Description= "Listagem dos clientes ativos",
                    ReferenceDate= new DateTime(2024,07,01),
                    Customers = new List<Customer> {
                        new Customer{
                            Name = "Pedro",
                            Birthdate= new DateTime(1987,02,02)
                        },
                        new Customer{
                            Name = "João",
                            Birthdate= new DateTime(1998,12,20)
                        },
                    }
                },
                 new ListItem {
                    Id = 3,
                    Title= "Clientes com saldo negativo",
                    Description= "Listagem dos clientes com saldo negativo",
                    ReferenceDate= new DateTime(2024,07,01),
                    Customers = new List<Customer> {
                        new Customer{
                            Name = "Thiago",
                            Birthdate= new DateTime(1988,04,12)
                        },
                        new Customer{
                            Name = "Gustavo",
                            Birthdate= new DateTime(2000,09,17)
                        },
                    }
                },
                 new ListItem {
                    Id = 4,
                    Title= "Clientes com saldo positivo",
                    Description= "Listagem dos clientes com saldo positivo",
                    ReferenceDate= new DateTime(2024,07,01),
                    Customers = new List<Customer> {
                        new Customer{
                            Name = "Ivony",
                            Birthdate= new DateTime(2011,07,18)
                        },
                        new Customer{
                            Name = "Sheila",
                            Birthdate= new DateTime(2012,06,09)
                        },
                    }
                },
                 new ListItem {
                    Id = 5,
                    Title= "Clientes com investimentos em USD",
                    Description= "Listagem dos clientes com investimentos em USD",
                    ReferenceDate= new DateTime(2024,07,01),
                    Customers = new List<Customer> {
                        new Customer{
                            Name = "Lady",
                            Birthdate= new DateTime(1990,09,12)
                        },
                        new Customer{
                            Name = "Lion",
                            Birthdate= new DateTime(2004,04,04)
                        },
                    }
                },
                 new ListItem {
                    Id = 6,
                    Title= "Clientes com investimentos em BRL",
                    Description= "Listagem dos clientes com investimentos em BRL",
                    ReferenceDate= new DateTime(2024,07,01),
                    Customers = new List<Customer> {
                        new Customer{
                            Name = "Jorge",
                            Birthdate= new DateTime(1990,01,25)
                        },
                        new Customer{
                            Name = "Gustavo",
                            Birthdate= new DateTime(2000,02,25)
                        },
                    }
                },
                 new ListItem {
                    Id = 7,
                    Title= "Clientes recém nascidos",
                    Description= "Listagem dos clientes recém nascidos",
                    ReferenceDate= new DateTime(2024,07,01),
                    Customers = new List<Customer> {
                        new Customer{
                            Name = "Ezequiel",
                            Birthdate= new DateTime(2024,07,01)
                        }
                    }
                },
            };
        }
    }
}
