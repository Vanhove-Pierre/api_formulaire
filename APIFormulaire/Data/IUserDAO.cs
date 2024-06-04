using APIFormulaire.Model;

namespace APIFormulaire.Data;

public interface IUserDAO
{
    public User[] GetAllUser();
    public User GetUserById(int id);
    public void CreateUser(User user);
    public void DeleteUser(User user);
    public void UpdateUser(User user);
}