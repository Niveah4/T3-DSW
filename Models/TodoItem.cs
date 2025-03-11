namespace TodoWebService.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty; 
    }
}