using System.ComponentModel.DataAnnotations;

namespace ExpensiveControlApp.DTOs
{
    public class CreateExpensiveDTO
    {
        public CreateExpensiveDTO()
        {
            Date = DateTime.Now;
        }

        [Required(ErrorMessage = "Descrição é Obrigatória")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Valor é Obrigatório")]
        [Range(0.01, 99999999, ErrorMessage = "Valor deve ser maior que zero")]
        public double Value { get; set; }

        [Required(ErrorMessage = "Data é obrigatória")]
        public DateTime Date { get; set; }
    }
}
