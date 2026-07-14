
using June2026ConsoleApp5;
using June2026Database.AppDbContextModels;

June2026AppDbContext db = new June2026AppDbContext();
//var lst = db.Staffs.ToList();
//foreach (var item in lst)
//{
//    Console.WriteLine(item.Id);
//    Console.WriteLine(item.Name);
//    Console.WriteLine("----------");
//}


//var staff2 = db.Staffs.Where(x => x.Id == 1000).FirstOrDefault();

//insert
//StaffEntity staffEntity = new StaffEntity()
//{
//    Name = "Aung Aung"
//};
//db.Staffs.Add(staffEntity);
//int result = db.SaveChanges();
//Console.WriteLine("Staff Added");


//update
//StaffEntity? staff = db.Staffs.Where(x => x.Id == 1).FirstOrDefault();
//if (staff is null)
//{
//    Console.WriteLine("Staff not found");
//}
//else
//{
//    staff.Name = "Aye Aye";
//    int result = db.SaveChanges();//executes
//}

//delete
StaffEntity? staff = db.Staffs.Where(x => x.Name == "Aung Aung").FirstOrDefault();
db.Staffs.Remove(staff);
int result = db.SaveChanges();
Console.WriteLine($"{result} rows affected");


//AppDbContext db2=new AppDbContext();
//var lst2=db2.TblStaff3s.ToList();
//var lst3=db2.TblStudent1s.ToList();

//db2.TblStaff3s.Where(x => x.StaffId > 1).OrderBy(x => x.StaffName);


//Efcore Assignment
//AppDbContext db3 = new AppDbContext();
//var lst4 = db3.TblCustomers.ToList();
//foreach (var item in lst4)
//{
//    Console.WriteLine(item.CustomerId);
//    Console.WriteLine(item.CustomerName);
//    Console.WriteLine(item.Email);
//    Console.WriteLine(item.PhoneNumber);
//    Console.WriteLine(item.Address);
//    Console.WriteLine("--------------");

//    Console.WriteLine("----------");
//}


//deleted table
//AppDbContext db4 = new AppDbContext();
//var lst5 = db4.MenuItems.ToList();  
//foreach (var item in lst5)
//{
//    Console.WriteLine(item.MenuItemId);
//    Console.WriteLine(item.ItemName);
//    Console.WriteLine(item.Category);
//    Console.WriteLine(item.Price);
//    Console.WriteLine(item.StockQty);
//    Console.WriteLine("--------------");

//    Console.WriteLine("----------");
//}


//AppDbContext db5 = new AppDbContext();
//var lst6 = db5.Employees.ToList();
//foreach (var item in lst6)
//{
//    Console.WriteLine(item.EmployeeId);
//    Console.WriteLine(item.EmployeeName);
//    Console.WriteLine(item.Position);
//    Console.WriteLine(item.Phone);
//    Console.WriteLine(item.Salary);
//    Console.WriteLine("--------------");

//}

Console.ReadLine();
