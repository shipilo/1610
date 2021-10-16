using System;
using System.Collections.Generic;

namespace Met_1610
{
	public enum AccountType
	{
		Current,
		Saving
	}
	public class Account
	{
		private int index;
		private AccountType accountType;
		private int balance;
				
		static int indexer = 0;
		static List<int> indexes = new List<int>();
		public Account()
        {
			index = index++;
        }
		public Account(int Index, AccountType AccountType, int Balance)
		{
			this.Index = Index;
			accountType = AccountType;
			balance = Balance;
			indexer++;
		}
		public Account(AccountType AccountType, int Balance)
		{
			index = indexer++;
			accountType = AccountType;
			balance = Balance;
		}
		public int Index
		{
			get => index;
			set
			{
				if (!indexes.Contains(Index))
				{
					index = value;
					indexes.Add(Index);
				}
				else
                {
					throw new Exception("Экземляр с таким номером уже существует");
                }
			}
		}
		public AccountType AccountType 
		{ 
			get => accountType; 
			set => accountType = value; 
		}
		public int Balance 
		{ 
			get => balance;
			set => balance = value; 
		}

		public string OutPut()
		{
			return ($"Номер: {Index}\nТип: {AccountType}\nБаланс: {Balance}\n");
		}
		public void Withdraw(int sum)
		{
			if (sum <= balance)
			{
				balance -= sum;
			}
		}
		public void PutInBalance(int sum)
		{
			if (sum > 0)
			{
				balance += sum;
			}
		}
	}
	class Building
	{
		private int index;
		private double high;
		private int storeys;
		private int aparts;
		private int entrances;

		static int indexer = 0;        
		static List<int> indexes = new List<int>();
		public Building()
        {
			index = indexer++;
		}
		public Building(double High, int Storeys, int Aparts, int Entrances)
        {
			index = indexer++;
			this.High = High;
			this.Storeys = Storeys;
			this.Aparts = Aparts;
			this.Entrances = Entrances;
        }
		public int Index 
		{ 
			get => index;
			set
			{
				if (!indexes.Contains(Index))
				{
					if (Index > 0)
					{
						index = value;
						indexes.Add(Index);
					}
					else
                    {
						throw new ArgumentOutOfRangeException("Значение может быть только положительным числом.");
					}
				}
				else
				{
					throw new Exception("Экземляр с таким номером уже существует.");
				}
			}
		}
		public double High 
		{
			get => high;
			set
			{
				if (high > 0)
				{
					high = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException("Значение может быть только положительным числом.");
				}
			}

		}
		public int Storeys 
		{
			get => storeys;
			set
			{
				if (storeys > 0)
				{
					storeys = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException("Значение может быть только натуральным числом.");
				}
			}

		}
		public int Aparts 
		{ 
			get => aparts;
			set
			{
				if (aparts > 0)
				{
					aparts = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException("Значение может быть только натуральным числом.");
				}
			}
		}
        public int Entrances 
		{ 
			get => entrances;
			set
			{
				if (entrances > 0)
				{
					entrances = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException("Значение может быть только натуральным числом.");
				}
			}
		}
		public double GetHighOfStorey(int NumberOfStorey)
        {
			if (NumberOfStorey <= storeys && NumberOfStorey > 0)
            {
				return high / storeys * NumberOfStorey;
            }
			else
            {
				throw new ArgumentOutOfRangeException("Такого номера этажа не существует.");
			}
        }
		public int GetApartNumberOfEntrance()
		{
			return aparts / entrances;
		}
		public int GetApartNumberOfStorey()
        {
			return GetApartNumberOfEntrance() / storeys;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Упражнение 7.1");
			Account account1 = new Account(1, AccountType.Current, 100);
			Account account2 = new Account(2, AccountType.Saving, 1000);
			Account account3 = new Account(3, AccountType.Current, 1000);
			Console.WriteLine(account1.OutPut());
			Console.WriteLine(account2.OutPut());
			Console.WriteLine(account3.OutPut());

			Console.WriteLine("Упражнение 7.2");
			Account account4 = new Account(AccountType.Current, 10);
			Console.WriteLine(account4.OutPut());

			Console.WriteLine("Упражнение 7.3");
			account4.PutInBalance(10);
			account4.Withdraw(20);
			Console.WriteLine(account4.OutPut());

			Console.WriteLine("Домашнее задание 7.1");
			try
			{
				Building build = new Building();			
				build.GetHighOfStorey(1);
			}
            catch(Exception e)
            {
				Console.WriteLine(e);
            }

			Console.ReadLine();

		}
	}
}
