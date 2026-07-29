
using June2026ConsoleApp6;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

Start:
Console.WriteLine("User List: ");
Console.WriteLine("1. View Users");
Console.WriteLine("2. Add User");
Console.WriteLine("3. Update User");//2 steps
Console.WriteLine("4. Delete User");
Console.WriteLine("5. Exit");
int number = 0; 
Console.Write("Choose an option: ");
string strNumber = Console.ReadLine();
number = Convert.ToInt32(strNumber);
if (number == 1)
{
    //View users
    HttpClient client = new HttpClient();
    HttpResponseMessage response = await client.GetAsync("https://localhost:7061/api/user");
    if (response.IsSuccessStatusCode)
    {
        string content = await response.Content.ReadAsStringAsync();
        //Console.WriteLine(content);
        //Serialize=> obj to json
        var users = JsonConvert.DeserializeObject<List<UserModel>>(content);//json to obj
        int count = 0;
        foreach (var user in users)
        {
            Console.WriteLine($"{++count}.Userid:{user.UserId}, Username:{user.Username}");

        }
    }

}
else if (number == 2)
{
    //Add users
    Console.Write("Enter Username: ");
    String username = Console.ReadLine()!;
    Console.Write("Enter Password: ");
    String password = Console.ReadLine()!;
    UserCreateRequestModel requestModel = new UserCreateRequestModel
    {
        Username = username,
        Password = password
    };

    string json = JsonConvert.SerializeObject(requestModel);//obj to json
    HttpClient client = new HttpClient();
    var stringcontent = new StringContent(json, Encoding.UTF8, Application.Json);
    HttpResponseMessage response = await client.PostAsync("https://localhost:7061/api/user", stringcontent);

    if (response.IsSuccessStatusCode)
    {
        string content = await response.Content.ReadAsStringAsync();
        var responseModel = JsonConvert.DeserializeObject<UserCreateResponseModel>(content);//json to obj
        Console.WriteLine(responseModel.Message);

    }
}
else if (number == 3)
{

    Console.Write("Enter User Id: ");
    string Userid = Console.ReadLine();
    Console.Write("Enter Username: ");
    String username = Console.ReadLine();
    Console.Write("Enter Password: ");
    String password = Console.ReadLine();
    UserPatchRequestModel requestModel = new UserPatchRequestModel
    {
        Username = username,
        Password = password
    };


    string json = JsonConvert.SerializeObject(requestModel);//obj to json
    HttpClient client = new HttpClient();
    var stringcontent = new StringContent(json, Encoding.UTF8, Application.Json);
    HttpResponseMessage response = await client.PatchAsync($"https://localhost:7061/api/user/{Userid}", stringcontent);

    if (response.IsSuccessStatusCode)
    {
        string content = await response.Content.ReadAsStringAsync();
        var responseModel = JsonConvert.DeserializeObject<UserPatchResponseModel>(content);//json to obj
        Console.WriteLine(responseModel.Message);

    }
}
else if (number == 4)
{
    //Delete users
    Console.Write("Enter User Id: ");
    string Userid = Console.ReadLine()!;
    HttpClient client = new HttpClient();
    HttpResponseMessage response = await client.DeleteAsync($"https://localhost:7061/api/user/{Userid}");
    if (response.IsSuccessStatusCode)
    {
        string content = await response.Content.ReadAsStringAsync();
        var responseModel= JsonConvert.DeserializeObject<UserDeleteResponseModel>(content);//json to obj
        Console.WriteLine(responseModel.Message.ToString());
        

    }
}
else
{
    goto Exit;
}

    goto Start;

Exit:
    Console.WriteLine("Exiting...");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
