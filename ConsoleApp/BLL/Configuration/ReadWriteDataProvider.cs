namespace BLL
{
    public class ReadWriteDataProvider
    {
        private static ReadWriteDataProvider instance;

        public ReadWriteService<Student> readWriteStudent;
        public ReadWriteService<Librarian> readWriteLibrarian;
        public ReadWriteService<SoftwareDeveloper> readWriteDeveloper;

        protected ReadWriteDataProvider(ReadWriteService<Student> _readWriteStudent, ReadWriteService<Librarian> _readWriteLibrarian,
            ReadWriteService<SoftwareDeveloper> _readWriteDeveloper)
        {
            readWriteStudent = _readWriteStudent;
            readWriteLibrarian = _readWriteLibrarian;
            readWriteDeveloper = _readWriteDeveloper;
        }

        public static ReadWriteDataProvider GetInstance(ReadWriteService<Student> _readWriteStudent,
            ReadWriteService<Librarian> _readWriteLibrarian, ReadWriteService<SoftwareDeveloper> _readWriteDeveloper)
        {
            if (instance == null)
                instance = new ReadWriteDataProvider(_readWriteStudent, _readWriteLibrarian, _readWriteDeveloper);
            return instance;
        }
    }

}
