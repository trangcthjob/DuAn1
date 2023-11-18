namespace Infrastructure
{
    public interface IDAT_Entity
    {
        /// <summary>
        /// Mã
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Đã xóa
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}