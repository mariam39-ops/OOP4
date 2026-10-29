namespace AssigmentOOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //answer 1
            #region part 1 answer 1,2 
            //q1
            // a=q1 يعني انا بظهر للمستخدم الوظائف والمعلومات الاساسيه وبخفى عنه تفاصيل التنفيذ
            //b=q2 اكتر 3 بيسهل علينا الصيانه بقلل التعقيد يعني انا بخفى عن المستخدم الحاجه الى مش بتفيده 2كمان بتخلي الكود redable 

            //q2 
            // abstract class: ده كلاس عنده فيلد وميثود وبيحصل فيه وراثه وكمان عنده كونستراكتور مينفعش نعمل منه اوبجيكت مباشر بالnew
            //interfas هو مجرد عقد بين اكتر من كلاس عمره م يحتوي على  فيلد ولا عنده كونستراكتور ولا بيورث  من كلاس ممكن يورث من انترفيس 
            //q2 لما اكون عايزه اعمل contract الكلاس عايزاهم ينفذوها  لما مكونش محتاجه انه يورث من الاب حاجه
            //q3 الكلاس ميقدرش يورث اكتر من abstract class ال لكن الكلاس يقدر يورث من  اكتر interface

            #endregion

            //q8
            //q1
            DeliveryAddress d = new DeliveryAddress();
            StandaredShipment s1 = new StandaredShipment("333","cloth",55,44.90m,d);
            //q2
            ExpressShipment e1 = new ExpressShipment("88", "laptops", 80m, 88.99m, d, 888);
            //q3
            InternationalShipment i = new InternationalShipment("88", "laptops", 80m, 88.99m, d, "5%", 99.77m);
            //q3
            DeliveryCenter del = new DeliveryCenter("mm");
            del.AddShipment(s1);
            del.AddShipment(e1);
            del.AddShipment(i);
            //q4
            del.PrintAllShipment();
        }
    }
}
