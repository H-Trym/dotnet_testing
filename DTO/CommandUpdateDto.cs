#nullable disable

namespace dotnetTest.DTO
{
    public class CommandUpdateDto
    {
        public CommandUpdateDto()
        {
            this.HowTo = "";
            this.Line = "";
            this.Platform = "";
        }
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; } 
    }
}