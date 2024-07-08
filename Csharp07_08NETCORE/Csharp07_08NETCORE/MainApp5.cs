// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// // 중첩 클래스 (Nested Class)
// //      클래스 안에 또 다른 클래스를 선언하는 것
// //      중첩 클래스는 외부 클래스의 모든 멤버에 접근할 수 있음
// //      중첩 클래스는 private, protected, public, internal 등의 접근 제한자를 사용할 수 있음
// //      중첩 클래스는 외부 클래스의 인스턴스를 생성하지 않고도 사용할 수 있음
// //      중첩 클래스는 외부 클래스의 멤버를 자유롭게 사용할 수 있음
// // 쓰는 이유
// //      1. 클래스 외부에 공개하고 싶지 않은 형식을 만들 때
// //      2. 현재 클래스의 일부분으로만 사용되는 클래스를 만들 때
// // 다른 클래스의 private 멤버에서도 접근 가능한 중첩 클래스는
// // 은닉성을 위반하지만, 유연한 설계를 가능하게 함

// namespace Csharp07_08NETCORE
// {
//     class Configuration
//     {
//         List<ItemValue> listConfig = new List<ItemValue>();
//         public void SetConfig(string item, string value)
//         {
//             ItemValue iv = new ItemValue();
//             iv.SetValue(this, item, value);
//         }
//         public string GetConfig(string item)
//         {
//             foreach (ItemValue iv in listConfig)
//             {
//                 if (iv.GetItem() == item)
//                     return iv.GetValue();
//             }
//             return "";
//         }
//         private class ItemValue
//         {
//             private string item;
//             private string value;
//             public void SetValue(Configuration config, string item, string value)
//             {
//                 this.item = item;
//                 this.value = value;
//                 bool found = false;
//                 //  중첩 클래스는 외부 클래스의 모든 멤버에 접근할 수 있음
//                 for (int i = 0; i < config.listConfig.Count; i++)
//                 {
//                     if (config.listConfig[i].item == item)
//                     {
//                         config.listConfig[i] = this;
//                         found = true;
//                         break;
//                     }
//                 }
//                 if (found == false)
//                     config.listConfig.Add(this);
//             }
//             public string GetItem()
//             {
//                 return item;
//             }
//             public string GetValue()
//             {
//                 return value;
//             }
//         }
//     }
//     internal class MainApp5
//     {
//         static void Main()
//         {
//             Configuration config = new Configuration();
//             config.SetConfig("Version", "V 5.0");
//             config.SetConfig("Size", "655,324 KB");
//             Console.WriteLine(config.GetConfig("Version"));
//             Console.WriteLine(config.GetConfig("Size"));
//             config.SetConfig("Version", "V 5.0.1");
//             Console.WriteLine(config.GetConfig("Version"));
//         }
//     }
// }
