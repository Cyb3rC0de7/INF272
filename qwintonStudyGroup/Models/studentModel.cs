using System.ComponentModel.DataAnnotations;

namespace qwintonStudyGroup.Models
{
	public class studentModel
	{
		[Display(Name = "Student Number")]
		public string studentNumber { get; set; }

		[Display (Name = "First Name")]
		public string name { get; set; }

		[Display (Name = "Last Name")]
		public string lastName { get; set; }

		[Display (Name = "Email")]
		public string email { get; set; }
	}
}