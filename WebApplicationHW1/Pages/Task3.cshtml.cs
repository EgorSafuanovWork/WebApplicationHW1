using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationHW1.Pages
{
    public class Task3Model : PageModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public void OnGet()
        {
            Name = "ϳ���� 13";
            Address = "��� ������ ��������";
            Phone = "88235";
        }
    }
}
