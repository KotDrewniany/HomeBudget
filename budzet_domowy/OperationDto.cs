using System;

namespace budzet_domowy
{
	public class OperationDto
	{
		public int Id { get; set; }

		public DateTime Data { get; set; }

		public decimal Price { get; set; }

		public int CategoryId { get; set; }

        public string Category { get; set; }

        public int PodcategoryId { get; set; }

        public string Podcategory { get; set; }

		public int UserId { get; set; }

        public string Type { get; set; }

        public int? PaymentFormId { get; set; }

        public string PaymentForm { get; set; }

		public string Description { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string FullName => Name + " " + Surname;
	}
}