namespace Student.UI
{

    //ააწყვეთ ავტორიზაციის და რეგისტრაციის ლოგიკა
    //სტუდენტების და მასწავლებლების მენეჯმენტი უნდა შეეძლოთ
    //მხოლოდ იმ ტიპებს რომლებიც გაივლიან ავტორიზაციას და ექნებათ Admin როლი
    //SQL ში უნდა შექმნათ user -ის ცხრილი შემდეგი პარამეტრებით:
    //ელ-ფოსტა
    //პაროლი


    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}