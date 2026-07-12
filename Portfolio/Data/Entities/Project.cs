using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
    public class Project
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Görsel IRL Boş bırakılamaz.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Proje Adı Boş bırakılamaz.")]
        [MinLength(3, ErrorMessage = "Proje Adı en az 3 karakter olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proje Açıklaması Boş bırakılamaz.")]
        [MaxLength(100, ErrorMessage = "Proje Açıklaması en fazla 100 karakter olmalıdır.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Proje GitHub URL'si Boş bırakılamaz.")]
        public string GitHubUrl { get; set; }


        public List<ProjectTechStack>? ProjectTechStacks { get; set; }
    }
}
