using System.ComponentModel.DataAnnotations;

namespace ASPNetCore_EF_ToDoList.Models
{
    public class ToDo
    {
        public ToDo()
        {
            Date = DateTime.Now;
            // seconden en milliseconden op 0 zetten (we gaan er vanuit dat gebruikers to-dos niet op de seconde of milliseconde willen plannen)
            Date = Date.AddMilliseconds(-Date.Millisecond).AddSeconds(-Date.Second);
        }
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public DateTime Date { get; private set; }
        [Required]

        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
    }
}
