using APIFormulaire.Model;

namespace APIFormulaire.Data;

public interface IQuestionDAO
{
    public Question[] GetAll();
    public Question GetById(int id);
    public void Create(Question question);
    public void Update(Question question);
    public void Delete(Question question);
}