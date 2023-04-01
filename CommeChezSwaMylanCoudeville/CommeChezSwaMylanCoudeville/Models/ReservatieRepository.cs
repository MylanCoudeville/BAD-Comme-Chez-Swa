namespace CommeChezSwaMylanCoudeville.Models
{
    public class ReservatieRepository
    {
        private static List<Reservatie> _reservaties = new List<Reservatie>();

        public static IEnumerable<Reservatie> GetAll()
        {
            return _reservaties.ToList();
        }

        public static Reservatie Get(int id)
        {
            return _reservaties.Find(reservatie => reservatie.Id == id);
        }
        public static int Add(Reservatie reservatie)
        {
            int id = _reservaties.Count() > 0 ? _reservaties.Max(reservatie => reservatie.Id) + 1 : 1;
            reservatie.Id = id;

            _reservaties.Add(reservatie);

            return id;
        }

        public static bool Delete(Reservatie reservatie)
        {
            return _reservaties.Remove(reservatie);
        }
    }
}
