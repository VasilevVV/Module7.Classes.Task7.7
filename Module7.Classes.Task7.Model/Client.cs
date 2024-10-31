
namespace Module7.Classes.Task7.Model
{

    /// <summary>
    /// Клиент
    /// </summary>
    public struct Client
    {
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Индентификатор клиента
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Номер телефона клиента
        /// </summary>
        public uint PhoneNamber { get; set; }
    }

}
