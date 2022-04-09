using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactSystems",
                keyColumn: "Contact_Id",
                keyValue: "f9044bc9-530b-4de0-b0d4-89bcf3181642");

            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cu_Id",
                keyValue: "28064fbc-8cdf-4c65-bc96-cf5014158295");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "2df89354-6e08-47d2-8b42-9ffaf3147050");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "6c833965-b764-4e8b-bc85-a108b3ece232");

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "1457e167-87bd-4555-ae4e-0b4a1448e821" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "1cc98150-48a1-4783-b933-17d316906ca5", "1c16a5b8-787c-429f-8fc9-ee6b71c02d8f" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "1cc98150-48a1-4783-b933-17d316906ca5", "1c3c1297-782f-4729-a1ec-a326c91bfcbb" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "232d9499-2e3f-490f-8541-45e08e12cc1e" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "07cf1e23-2691-4923-80f0-efbecef94a5c", "3497483f-ef59-4d93-b8e1-f4daf4c2ea1f" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "38748005-289d-4ef7-9a49-fa1138b6cd00" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "3897bf54-af14-4dba-8dc5-b476a7c525cc" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "c2353234-ed9e-4d4b-a087-f25a71cdcac5", "3a0e245a-d641-4ff7-b4de-c4ea64c837de" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "4464c176-42bc-4d8f-8ad4-9f37b50a98c7" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "47c84d2e-8da9-44d1-894f-e628c3a7de4c" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "c2353234-ed9e-4d4b-a087-f25a71cdcac5", "489cd014-4707-400f-919e-4fbb346d205f" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "07cf1e23-2691-4923-80f0-efbecef94a5c", "49cb5a13-cf57-423c-954b-0d95f8c69a8a" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "07cf1e23-2691-4923-80f0-efbecef94a5c", "511557c2-0003-4506-80d1-5c5332b6c58f" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "55f7b643-ebca-40e1-b592-8811ba0ae3ba" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "07cf1e23-2691-4923-80f0-efbecef94a5c", "60c0e2bb-a07b-4a03-9cd7-44226a2cda01" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "07cf1e23-2691-4923-80f0-efbecef94a5c", "7fbd8fce-55f0-4d87-87c7-ab0ceeb44948" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "07cf1e23-2691-4923-80f0-efbecef94a5c", "8d142bf2-ef31-4a24-bd9b-784612b1d77e" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "8e28728f-725f-41f9-95be-e6e6ce83b1d6" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "07cf1e23-2691-4923-80f0-efbecef94a5c", "8e5769df-3c2e-4634-9d19-c732af2ad555" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "94a72205-0018-457b-bc59-916c38dcb9d0" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "980b9440-4392-4f3e-a339-d943a264ba93" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "07cf1e23-2691-4923-80f0-efbecef94a5c", "9ed428bf-1a86-41c2-90af-39f7507ca227" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "af35f87e-4dd0-4fe0-9862-62d0dee0c2fd" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "d28ca46d-4808-4f94-9564-edfab255aa8e" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "07cf1e23-2691-4923-80f0-efbecef94a5c", "d80b0de3-9f4a-4482-8a54-e984aa2caed8" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "1cc98150-48a1-4783-b933-17d316906ca5", "f06aa333-4851-4011-95c0-cda7aba28e84" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "1cc98150-48a1-4783-b933-17d316906ca5", "fcf6009d-f719-402d-80ad-2d6ee8040963" });

            migrationBuilder.DeleteData(
                table: "ReviewInproduct",
                keyColumns: new[] { "rip_ProductId", "rip_ReviewId" },
                keyValues: new object[] { "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea", "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" });

            migrationBuilder.DeleteData(
                table: "ReviewInproduct",
                keyColumns: new[] { "rip_ProductId", "rip_ReviewId" },
                keyValues: new object[] { "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea", "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" });

            migrationBuilder.DeleteData(
                table: "ReviewInproduct",
                keyColumns: new[] { "rip_ProductId", "rip_ReviewId" },
                keyValues: new object[] { "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea", "EEBA6608-AB75-4E83-909F-604B1A06F16C" });

            migrationBuilder.DeleteData(
                table: "SubReviewInReview",
                keyColumns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                keyValues: new object[] { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "f80033ea-49ca-477c-8f96-7aaaa96f91fb" });

            migrationBuilder.DeleteData(
                table: "SubReviewInReview",
                keyColumns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                keyValues: new object[] { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "134597a7-e2f9-4ff7-8ec4-2890a6357981" });

            migrationBuilder.DeleteData(
                table: "SubReviewInReview",
                keyColumns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                keyValues: new object[] { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "60b032c6-3cd1-43f8-9777-bdbe23677589" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "07cf1e23-2691-4923-80f0-efbecef94a5c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "18236757-322e-45ed-ba73-aaf7e8a3a4b7");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "1cc98150-48a1-4783-b933-17d316906ca5");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "bd7f2c9a-44c8-442a-9128-296acc7111c3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "c2353234-ed9e-4d4b-a087-f25a71cdcac5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "1457e167-87bd-4555-ae4e-0b4a1448e821");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "1c16a5b8-787c-429f-8fc9-ee6b71c02d8f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "1c3c1297-782f-4729-a1ec-a326c91bfcbb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "232d9499-2e3f-490f-8541-45e08e12cc1e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "3497483f-ef59-4d93-b8e1-f4daf4c2ea1f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "38748005-289d-4ef7-9a49-fa1138b6cd00");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "3897bf54-af14-4dba-8dc5-b476a7c525cc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "3a0e245a-d641-4ff7-b4de-c4ea64c837de");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "4464c176-42bc-4d8f-8ad4-9f37b50a98c7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "47c84d2e-8da9-44d1-894f-e628c3a7de4c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "489cd014-4707-400f-919e-4fbb346d205f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "49cb5a13-cf57-423c-954b-0d95f8c69a8a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "511557c2-0003-4506-80d1-5c5332b6c58f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "55f7b643-ebca-40e1-b592-8811ba0ae3ba");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "60c0e2bb-a07b-4a03-9cd7-44226a2cda01");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "7fbd8fce-55f0-4d87-87c7-ab0ceeb44948");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "8d142bf2-ef31-4a24-bd9b-784612b1d77e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "8e28728f-725f-41f9-95be-e6e6ce83b1d6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "8e5769df-3c2e-4634-9d19-c732af2ad555");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "94a72205-0018-457b-bc59-916c38dcb9d0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "980b9440-4392-4f3e-a339-d943a264ba93");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "9ed428bf-1a86-41c2-90af-39f7507ca227");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "af35f87e-4dd0-4fe0-9862-62d0dee0c2fd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d28ca46d-4808-4f94-9564-edfab255aa8e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d80b0de3-9f4a-4482-8a54-e984aa2caed8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "f06aa333-4851-4011-95c0-cda7aba28e84");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "fcf6009d-f719-402d-80ad-2d6ee8040963");

            migrationBuilder.DeleteData(
                table: "SubReview",
                keyColumn: "subReview_Id",
                keyValue: "134597a7-e2f9-4ff7-8ec4-2890a6357981");

            migrationBuilder.DeleteData(
                table: "SubReview",
                keyColumn: "subReview_Id",
                keyValue: "60b032c6-3cd1-43f8-9777-bdbe23677589");

            migrationBuilder.DeleteData(
                table: "SubReview",
                keyColumn: "subReview_Id",
                keyValue: "f80033ea-49ca-477c-8f96-7aaaa96f91fb");

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "D269BF93-A5E2-4C4A-8146-9967DDE80D30",
                column: "bill_DatetimeOrder",
                value: new DateTime(2022, 4, 9, 22, 36, 8, 947, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "Snack", "", "" },
                    { "fdfd170e-da69-4178-999c-61dff3f9c706", "Banhmi", "", "" },
                    { "5ffb00f5-4134-4942-b681-bef61732cf63", "Dry food", "", "" },
                    { "c12a90b6-6e3a-4299-8792-9a30ae7853f4", "Food", "", "" },
                    { "54873218-c198-4d27-9df4-78dc0dbcfabc", "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_Description", "Contact_Email", "Contact_Phone" },
                values: new object[] { "8dc41ae7-53bf-46c1-abe2-242f0a3d2a43", "Huntsville, AL 35813, USA", "Prof Lord John Krebs provides a brief history of human food, from our remote ancestors 3 million years ago to the present day. By looking at the four great transitions in human food - cooking, agriculture, processing, and preservation - he considers a variety of questions, including why people like some kinds of foods and not others; how your senses contribute to flavor; the role of genetics in our likes and dislikes; and the differences in learning and culture around the world.", "support@foodshop.com ", "021.343.7575" });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_FirstName", "cu_LastName", "cu_Subject" },
                values: new object[] { "b788477d-927d-48a0-837c-c9214a74ec2b", "Description", "Email", "FirstName", "LastName", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "couponCode", "couponPrice" },
                values: new object[,]
                {
                    { "903e9b7f-33b2-4cd5-8d9c-dc43895e2f31", "code10", 10 },
                    { "1b777f91-d327-459a-8437-6e847a5e5082", "code50", 50 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { "5cf5747d-6cd9-4a5a-b066-a7d3a9605960", "loteria", "/images/item250x300/loteria.png", "", "", "", "loteria", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "34b48aca-7e1c-4a5b-ac36-4061c6eafae2", "mitronanvat", "/images/item250x300/mitronanvat.png", "", "", "", "mitronanvat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "7a9055a9-e5af-41df-9894-1335c7d062a2", "monngontrangbang", "/images/item250x300/monngontrangbang.png", "", "", "", "monngontrangbang", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "93513e52-eedc-434e-833d-3114931ee399", "ParisBaguete", "/images/item250x300/ParisBaguete.png", "", "", "", "ParisBaguete", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "975aa6cb-099b-4bf6-8abe-2872a0b4ed3f", "pizza", "/images/item250x300/pizza.png", "", "", "", "pizza", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "5a445e10-ab27-41df-bafe-4b5dd58ef1c4", "Royaltea", "/images/item250x300/Royaltea.png", "", "", "", "Royaltea", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "944618db-1565-4834-a0f0-fe1d30edc3a0", "RauMaMix", "/images/item250x300/RauMaMix.png", "", "", "", "RauMaMix", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "2bcac237-81f4-482f-80e7-3d5c5e6438ac", "Sanfulou", "/images/item250x300/Sanfulou.png", "", "", "", "Sanfulou", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "c786c6be-5bd8-4332-bb76-593fdbcefcd4", "stacbuk-cf", "/images/item250x300/stacbuk-cf.png", "", "", "", "stacbuk-cf", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "0d6b00f0-b1cd-4c60-ae2d-bb5cf7ff5a0c", "trasuanhalam", "/images/item250x300/trasuanhalam.png", "", "", "", "trasuanhalam", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "ae59ffd7-9792-477a-8a04-07f9b1882d52", "Xoixeoba3beo", "/images/item250x300/Xoixeoba3beo.png", "", "", "", "Xoixeoba3beo", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "bd57e269-9f26-4ae8-bbb1-373582db497c", "quanngontrangbang", "/images/item250x300/quanngontrangbang.png", "", "", "", "quanngontrangbang", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "98a19f4f-629e-4394-8670-7c42fd620952", "kfc", "/images/item250x300/kfc.png", "", "", "", "kfc", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "3b46170c-0f4f-40eb-a3a5-822aa4c1d803", "KimBap", "/images/item250x300/KimBap.png", "", "", "", "KimBap", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "387e186d-375c-47c1-b55e-eb41638608fe", "denhatthitnuong", "/images/item250x300/denhatthitnuong.png", "", "", "", "denhatthitnuong", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "a111bfe8-2581-4e95-a98e-66eaa491ce36", "BanhCanhCua", "/images/item250x300/BanhCanhCua.png", "", "", "", "BanhCanhCua", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "0f418969-a34d-4ac4-9478-43d95e9d51cb", "BanhMi", "/images/item250x300/BanhMi.png", "", "", "", "BanhMi", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "f358d58d-17a3-40af-9185-28d932f56ca8", "banhuotlongdalat", "/images/item250x300/banhuotlongdalat.png", "", "", "", "banhuotlongdalat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "cdb4d659-ff75-4b1c-83b9-9d926f285cd1", "BoKho", "/images/item250x300/BoKho.png", "", "", "", "BoKho", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "533d47e2-6ffe-4b47-9d57-d8f2024f3849", "bunbo", "/images/item250x300/bunbo.png", "", "", "", "bunbo", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "0db97a4a-601b-49a3-a800-50294e15ef59", "banhtrangtron", "/images/item250x300/banhtrangtron.png", "", "", "", "banhtrangtron", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "57dfe101-8f04-4c0c-83ce-e1e6eb042818", "Bunxaochay", "/images/item250x300/Bunxaochay.png", "", "", "", "Bunxaochay", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "a3ab62a2-2c60-4e9a-b5f5-be77b9ea8b31", "cocosummer", "/images/item250x300/cocosummer.png", "", "", "", "cocosummer", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "21dffbb7-5c5b-4349-9916-0f0a65f0726b", "comboxao", "/images/item250x300/comboxao.png", "", "", "", "comboxao", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "59ec8692-3471-44de-9d18-6074fe0b3307", "comga", "/images/item250x300/comga.png", "", "", "", "comga", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "ce728ca3-6c1b-4b3f-be16-3ecb2356b89a", "comgadenhat", "/images/item250x300/comgadenhat.png", "", "", "", "comgadenhat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "f2767ce3-f6e3-43bc-afad-722c797872a6", "bundaumamtom", "/images/item250x300/bundaumamtom.png", "", "", "", "bundaumamtom", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "845efd83-707d-4063-bdf0-b75be6110ec5", "goicuon", "/images/item250x300/goicuon.png", "", "", "", "goicuon", "1", "2", "3", "4", 1, 5, 0, "Short Description", false }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                column: "ConcurrencyStamp",
                value: "39842734-d175-4bc9-ae1a-f4f073e956c1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                column: "ConcurrencyStamp",
                value: "b68ee0a8-9f9a-4092-9265-973ff3e54eca");

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[,]
                {
                    { "4bdc5424-eaed-4acc-86de-2327b3be0896", "subreview 1", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" },
                    { "76c4818b-c4c5-454f-9f57-9d983599b7a8", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", "SubReview" }
                });

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[] { "5a1422a2-8879-4868-9764-f3502ac823c4", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61805642-eca7-48ef-b3c1-b7922e0b1e81", "AQAAAAEAACcQAAAAEAd8jitxoso0dKR2aWdAzXBUMHaZilWmDRfFocGPK2TWNalxxgmD9D5RfbU7IArYJA==", "9eee2c68-3270-45cb-9ec9-7f9cceabad40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3299b22e-5c0d-4b02-b59f-2aff8dc7fbfb", "AQAAAAEAACcQAAAAELA5W1CoqiaMimtoS+oEs4G1ZMRQW8zmMmSc8J7+MXbek7jzvMDXmkCsdewcy1olPA==", "1d11a46d-657f-4378-8b29-6754925c6962" });

            migrationBuilder.InsertData(
                table: "ProductsInCategories",
                columns: new[] { "pic_CategoriesId", "pic_productId" },
                values: new object[,]
                {
                    { "c12a90b6-6e3a-4299-8792-9a30ae7853f4", "a111bfe8-2581-4e95-a98e-66eaa491ce36" },
                    { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "ae59ffd7-9792-477a-8a04-07f9b1882d52" },
                    { "54873218-c198-4d27-9df4-78dc0dbcfabc", "0d6b00f0-b1cd-4c60-ae2d-bb5cf7ff5a0c" },
                    { "54873218-c198-4d27-9df4-78dc0dbcfabc", "c786c6be-5bd8-4332-bb76-593fdbcefcd4" },
                    { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "2bcac237-81f4-482f-80e7-3d5c5e6438ac" },
                    { "54873218-c198-4d27-9df4-78dc0dbcfabc", "5a445e10-ab27-41df-bafe-4b5dd58ef1c4" },
                    { "54873218-c198-4d27-9df4-78dc0dbcfabc", "944618db-1565-4834-a0f0-fe1d30edc3a0" },
                    { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "bd57e269-9f26-4ae8-bbb1-373582db497c" },
                    { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "975aa6cb-099b-4bf6-8abe-2872a0b4ed3f" },
                    { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "93513e52-eedc-434e-833d-3114931ee399" },
                    { "c12a90b6-6e3a-4299-8792-9a30ae7853f4", "7a9055a9-e5af-41df-9894-1335c7d062a2" },
                    { "fdfd170e-da69-4178-999c-61dff3f9c706", "34b48aca-7e1c-4a5b-ac36-4061c6eafae2" },
                    { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "5cf5747d-6cd9-4a5a-b066-a7d3a9605960" },
                    { "5ffb00f5-4134-4942-b681-bef61732cf63", "3b46170c-0f4f-40eb-a3a5-822aa4c1d803" },
                    { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "98a19f4f-629e-4394-8670-7c42fd620952" },
                    { "5ffb00f5-4134-4942-b681-bef61732cf63", "845efd83-707d-4063-bdf0-b75be6110ec5" },
                    { "c12a90b6-6e3a-4299-8792-9a30ae7853f4", "cdb4d659-ff75-4b1c-83b9-9d926f285cd1" },
                    { "5ffb00f5-4134-4942-b681-bef61732cf63", "ce728ca3-6c1b-4b3f-be16-3ecb2356b89a" },
                    { "5ffb00f5-4134-4942-b681-bef61732cf63", "59ec8692-3471-44de-9d18-6074fe0b3307" },
                    { "5ffb00f5-4134-4942-b681-bef61732cf63", "21dffbb7-5c5b-4349-9916-0f0a65f0726b" },
                    { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "a3ab62a2-2c60-4e9a-b5f5-be77b9ea8b31" },
                    { "5ffb00f5-4134-4942-b681-bef61732cf63", "57dfe101-8f04-4c0c-83ce-e1e6eb042818" },
                    { "5ffb00f5-4134-4942-b681-bef61732cf63", "f2767ce3-f6e3-43bc-afad-722c797872a6" },
                    { "c12a90b6-6e3a-4299-8792-9a30ae7853f4", "533d47e2-6ffe-4b47-9d57-d8f2024f3849" },
                    { "5ffb00f5-4134-4942-b681-bef61732cf63", "387e186d-375c-47c1-b55e-eb41638608fe" },
                    { "c12a90b6-6e3a-4299-8792-9a30ae7853f4", "f358d58d-17a3-40af-9185-28d932f56ca8" },
                    { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "0db97a4a-601b-49a3-a800-50294e15ef59" },
                    { "fdfd170e-da69-4178-999c-61dff3f9c706", "0f418969-a34d-4ac4-9478-43d95e9d51cb" }
                });

            migrationBuilder.InsertData(
                table: "ReviewInproduct",
                columns: new[] { "rip_ProductId", "rip_ReviewId" },
                values: new object[,]
                {
                    { "a111bfe8-2581-4e95-a98e-66eaa491ce36", "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" },
                    { "a111bfe8-2581-4e95-a98e-66eaa491ce36", "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" },
                    { "a111bfe8-2581-4e95-a98e-66eaa491ce36", "EEBA6608-AB75-4E83-909F-604B1A06F16C" }
                });

            migrationBuilder.InsertData(
                table: "SubReviewInReview",
                columns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                values: new object[,]
                {
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "76c4818b-c4c5-454f-9f57-9d983599b7a8" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "4bdc5424-eaed-4acc-86de-2327b3be0896" },
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "5a1422a2-8879-4868-9764-f3502ac823c4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactSystems",
                keyColumn: "Contact_Id",
                keyValue: "8dc41ae7-53bf-46c1-abe2-242f0a3d2a43");

            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cu_Id",
                keyValue: "b788477d-927d-48a0-837c-c9214a74ec2b");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "1b777f91-d327-459a-8437-6e847a5e5082");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "903e9b7f-33b2-4cd5-8d9c-dc43895e2f31");

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "54873218-c198-4d27-9df4-78dc0dbcfabc", "0d6b00f0-b1cd-4c60-ae2d-bb5cf7ff5a0c" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "0db97a4a-601b-49a3-a800-50294e15ef59" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "fdfd170e-da69-4178-999c-61dff3f9c706", "0f418969-a34d-4ac4-9478-43d95e9d51cb" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5ffb00f5-4134-4942-b681-bef61732cf63", "21dffbb7-5c5b-4349-9916-0f0a65f0726b" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "2bcac237-81f4-482f-80e7-3d5c5e6438ac" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "fdfd170e-da69-4178-999c-61dff3f9c706", "34b48aca-7e1c-4a5b-ac36-4061c6eafae2" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5ffb00f5-4134-4942-b681-bef61732cf63", "387e186d-375c-47c1-b55e-eb41638608fe" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5ffb00f5-4134-4942-b681-bef61732cf63", "3b46170c-0f4f-40eb-a3a5-822aa4c1d803" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "c12a90b6-6e3a-4299-8792-9a30ae7853f4", "533d47e2-6ffe-4b47-9d57-d8f2024f3849" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5ffb00f5-4134-4942-b681-bef61732cf63", "57dfe101-8f04-4c0c-83ce-e1e6eb042818" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5ffb00f5-4134-4942-b681-bef61732cf63", "59ec8692-3471-44de-9d18-6074fe0b3307" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "54873218-c198-4d27-9df4-78dc0dbcfabc", "5a445e10-ab27-41df-bafe-4b5dd58ef1c4" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "5cf5747d-6cd9-4a5a-b066-a7d3a9605960" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "c12a90b6-6e3a-4299-8792-9a30ae7853f4", "7a9055a9-e5af-41df-9894-1335c7d062a2" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5ffb00f5-4134-4942-b681-bef61732cf63", "845efd83-707d-4063-bdf0-b75be6110ec5" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "93513e52-eedc-434e-833d-3114931ee399" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "54873218-c198-4d27-9df4-78dc0dbcfabc", "944618db-1565-4834-a0f0-fe1d30edc3a0" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "975aa6cb-099b-4bf6-8abe-2872a0b4ed3f" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "98a19f4f-629e-4394-8670-7c42fd620952" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "c12a90b6-6e3a-4299-8792-9a30ae7853f4", "a111bfe8-2581-4e95-a98e-66eaa491ce36" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "a3ab62a2-2c60-4e9a-b5f5-be77b9ea8b31" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "ae59ffd7-9792-477a-8a04-07f9b1882d52" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "91931cf8-ef79-43a2-9b24-2972a37fe40c", "bd57e269-9f26-4ae8-bbb1-373582db497c" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "54873218-c198-4d27-9df4-78dc0dbcfabc", "c786c6be-5bd8-4332-bb76-593fdbcefcd4" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "c12a90b6-6e3a-4299-8792-9a30ae7853f4", "cdb4d659-ff75-4b1c-83b9-9d926f285cd1" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5ffb00f5-4134-4942-b681-bef61732cf63", "ce728ca3-6c1b-4b3f-be16-3ecb2356b89a" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5ffb00f5-4134-4942-b681-bef61732cf63", "f2767ce3-f6e3-43bc-afad-722c797872a6" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "c12a90b6-6e3a-4299-8792-9a30ae7853f4", "f358d58d-17a3-40af-9185-28d932f56ca8" });

            migrationBuilder.DeleteData(
                table: "ReviewInproduct",
                keyColumns: new[] { "rip_ProductId", "rip_ReviewId" },
                keyValues: new object[] { "a111bfe8-2581-4e95-a98e-66eaa491ce36", "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" });

            migrationBuilder.DeleteData(
                table: "ReviewInproduct",
                keyColumns: new[] { "rip_ProductId", "rip_ReviewId" },
                keyValues: new object[] { "a111bfe8-2581-4e95-a98e-66eaa491ce36", "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" });

            migrationBuilder.DeleteData(
                table: "ReviewInproduct",
                keyColumns: new[] { "rip_ProductId", "rip_ReviewId" },
                keyValues: new object[] { "a111bfe8-2581-4e95-a98e-66eaa491ce36", "EEBA6608-AB75-4E83-909F-604B1A06F16C" });

            migrationBuilder.DeleteData(
                table: "SubReviewInReview",
                keyColumns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                keyValues: new object[] { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "5a1422a2-8879-4868-9764-f3502ac823c4" });

            migrationBuilder.DeleteData(
                table: "SubReviewInReview",
                keyColumns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                keyValues: new object[] { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "4bdc5424-eaed-4acc-86de-2327b3be0896" });

            migrationBuilder.DeleteData(
                table: "SubReviewInReview",
                keyColumns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                keyValues: new object[] { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "76c4818b-c4c5-454f-9f57-9d983599b7a8" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "54873218-c198-4d27-9df4-78dc0dbcfabc");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "5ffb00f5-4134-4942-b681-bef61732cf63");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "91931cf8-ef79-43a2-9b24-2972a37fe40c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "c12a90b6-6e3a-4299-8792-9a30ae7853f4");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "fdfd170e-da69-4178-999c-61dff3f9c706");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "0d6b00f0-b1cd-4c60-ae2d-bb5cf7ff5a0c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "0db97a4a-601b-49a3-a800-50294e15ef59");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "0f418969-a34d-4ac4-9478-43d95e9d51cb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "21dffbb7-5c5b-4349-9916-0f0a65f0726b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "2bcac237-81f4-482f-80e7-3d5c5e6438ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "34b48aca-7e1c-4a5b-ac36-4061c6eafae2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "387e186d-375c-47c1-b55e-eb41638608fe");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "3b46170c-0f4f-40eb-a3a5-822aa4c1d803");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "533d47e2-6ffe-4b47-9d57-d8f2024f3849");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "57dfe101-8f04-4c0c-83ce-e1e6eb042818");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "59ec8692-3471-44de-9d18-6074fe0b3307");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "5a445e10-ab27-41df-bafe-4b5dd58ef1c4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "5cf5747d-6cd9-4a5a-b066-a7d3a9605960");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "7a9055a9-e5af-41df-9894-1335c7d062a2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "845efd83-707d-4063-bdf0-b75be6110ec5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "93513e52-eedc-434e-833d-3114931ee399");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "944618db-1565-4834-a0f0-fe1d30edc3a0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "975aa6cb-099b-4bf6-8abe-2872a0b4ed3f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "98a19f4f-629e-4394-8670-7c42fd620952");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a111bfe8-2581-4e95-a98e-66eaa491ce36");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a3ab62a2-2c60-4e9a-b5f5-be77b9ea8b31");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "ae59ffd7-9792-477a-8a04-07f9b1882d52");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "bd57e269-9f26-4ae8-bbb1-373582db497c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c786c6be-5bd8-4332-bb76-593fdbcefcd4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "cdb4d659-ff75-4b1c-83b9-9d926f285cd1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "ce728ca3-6c1b-4b3f-be16-3ecb2356b89a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "f2767ce3-f6e3-43bc-afad-722c797872a6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "f358d58d-17a3-40af-9185-28d932f56ca8");

            migrationBuilder.DeleteData(
                table: "SubReview",
                keyColumn: "subReview_Id",
                keyValue: "4bdc5424-eaed-4acc-86de-2327b3be0896");

            migrationBuilder.DeleteData(
                table: "SubReview",
                keyColumn: "subReview_Id",
                keyValue: "5a1422a2-8879-4868-9764-f3502ac823c4");

            migrationBuilder.DeleteData(
                table: "SubReview",
                keyColumn: "subReview_Id",
                keyValue: "76c4818b-c4c5-454f-9f57-9d983599b7a8");

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "D269BF93-A5E2-4C4A-8146-9967DDE80D30",
                column: "bill_DatetimeOrder",
                value: new DateTime(2022, 4, 1, 5, 4, 28, 115, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "Snack", "", "" },
                    { "c2353234-ed9e-4d4b-a087-f25a71cdcac5", "Banhmi", "", "" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "Dry food", "", "" },
                    { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "Food", "", "" },
                    { "1cc98150-48a1-4783-b933-17d316906ca5", "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_Description", "Contact_Email", "Contact_Phone" },
                values: new object[] { "f9044bc9-530b-4de0-b0d4-89bcf3181642", "Huntsville, AL 35813, USA", "Prof Lord John Krebs provides a brief history of human food, from our remote ancestors 3 million years ago to the present day. By looking at the four great transitions in human food - cooking, agriculture, processing, and preservation - he considers a variety of questions, including why people like some kinds of foods and not others; how your senses contribute to flavor; the role of genetics in our likes and dislikes; and the differences in learning and culture around the world.", "support@foodshop.com ", "021.343.7575" });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_FirstName", "cu_LastName", "cu_Subject" },
                values: new object[] { "28064fbc-8cdf-4c65-bc96-cf5014158295", "Description", "Email", "FirstName", "LastName", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "couponCode", "couponPrice" },
                values: new object[,]
                {
                    { "2df89354-6e08-47d2-8b42-9ffaf3147050", "code10", 10 },
                    { "6c833965-b764-4e8b-bc85-a108b3ece232", "code50", 50 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { "3497483f-ef59-4d93-b8e1-f4daf4c2ea1f", "loteria", "/images/item250x300/loteria.png", "", "", "", "loteria", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "3a0e245a-d641-4ff7-b4de-c4ea64c837de", "mitronanvat", "/images/item250x300/mitronanvat.png", "", "", "", "mitronanvat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "8e28728f-725f-41f9-95be-e6e6ce83b1d6", "monngontrangbang", "/images/item250x300/monngontrangbang.png", "", "", "", "monngontrangbang", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "d80b0de3-9f4a-4482-8a54-e984aa2caed8", "ParisBaguete", "/images/item250x300/ParisBaguete.png", "", "", "", "ParisBaguete", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "49cb5a13-cf57-423c-954b-0d95f8c69a8a", "pizza", "/images/item250x300/pizza.png", "", "", "", "pizza", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "1c3c1297-782f-4729-a1ec-a326c91bfcbb", "Royaltea", "/images/item250x300/Royaltea.png", "", "", "", "Royaltea", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "fcf6009d-f719-402d-80ad-2d6ee8040963", "RauMaMix", "/images/item250x300/RauMaMix.png", "", "", "", "RauMaMix", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "7fbd8fce-55f0-4d87-87c7-ab0ceeb44948", "Sanfulou", "/images/item250x300/Sanfulou.png", "", "", "", "Sanfulou", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "f06aa333-4851-4011-95c0-cda7aba28e84", "stacbuk-cf", "/images/item250x300/stacbuk-cf.png", "", "", "", "stacbuk-cf", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "1c16a5b8-787c-429f-8fc9-ee6b71c02d8f", "trasuanhalam", "/images/item250x300/trasuanhalam.png", "", "", "", "trasuanhalam", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "511557c2-0003-4506-80d1-5c5332b6c58f", "Xoixeoba3beo", "/images/item250x300/Xoixeoba3beo.png", "", "", "", "Xoixeoba3beo", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "60c0e2bb-a07b-4a03-9cd7-44226a2cda01", "quanngontrangbang", "/images/item250x300/quanngontrangbang.png", "", "", "", "quanngontrangbang", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "8e5769df-3c2e-4634-9d19-c732af2ad555", "kfc", "/images/item250x300/kfc.png", "", "", "", "kfc", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "980b9440-4392-4f3e-a339-d943a264ba93", "KimBap", "/images/item250x300/KimBap.png", "", "", "", "KimBap", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "232d9499-2e3f-490f-8541-45e08e12cc1e", "denhatthitnuong", "/images/item250x300/denhatthitnuong.png", "", "", "", "denhatthitnuong", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea", "BanhCanhCua", "/images/item250x300/BanhCanhCua.png", "", "", "", "BanhCanhCua", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "489cd014-4707-400f-919e-4fbb346d205f", "BanhMi", "/images/item250x300/BanhMi.png", "", "", "", "BanhMi", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "38748005-289d-4ef7-9a49-fa1138b6cd00", "banhuotlongdalat", "/images/item250x300/banhuotlongdalat.png", "", "", "", "banhuotlongdalat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "94a72205-0018-457b-bc59-916c38dcb9d0", "BoKho", "/images/item250x300/BoKho.png", "", "", "", "BoKho", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "1457e167-87bd-4555-ae4e-0b4a1448e821", "bunbo", "/images/item250x300/bunbo.png", "", "", "", "bunbo", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "8d142bf2-ef31-4a24-bd9b-784612b1d77e", "banhtrangtron", "/images/item250x300/banhtrangtron.png", "", "", "", "banhtrangtron", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "d28ca46d-4808-4f94-9564-edfab255aa8e", "Bunxaochay", "/images/item250x300/Bunxaochay.png", "", "", "", "Bunxaochay", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "9ed428bf-1a86-41c2-90af-39f7507ca227", "cocosummer", "/images/item250x300/cocosummer.png", "", "", "", "cocosummer", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "3897bf54-af14-4dba-8dc5-b476a7c525cc", "comboxao", "/images/item250x300/comboxao.png", "", "", "", "comboxao", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "4464c176-42bc-4d8f-8ad4-9f37b50a98c7", "comga", "/images/item250x300/comga.png", "", "", "", "comga", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "47c84d2e-8da9-44d1-894f-e628c3a7de4c", "comgadenhat", "/images/item250x300/comgadenhat.png", "", "", "", "comgadenhat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "af35f87e-4dd0-4fe0-9862-62d0dee0c2fd", "bundaumamtom", "/images/item250x300/bundaumamtom.png", "", "", "", "bundaumamtom", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "55f7b643-ebca-40e1-b592-8811ba0ae3ba", "goicuon", "/images/item250x300/goicuon.png", "", "", "", "goicuon", "1", "2", "3", "4", 1, 5, 0, "Short Description", false }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                column: "ConcurrencyStamp",
                value: "ead41db7-221b-4b99-ae8d-f2391b11028e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                column: "ConcurrencyStamp",
                value: "de96fc9a-321b-4f56-a7a8-62dc16b0f6b4");

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[,]
                {
                    { "134597a7-e2f9-4ff7-8ec4-2890a6357981", "subreview 1", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" },
                    { "60b032c6-3cd1-43f8-9777-bdbe23677589", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", "SubReview" }
                });

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[] { "f80033ea-49ca-477c-8f96-7aaaa96f91fb", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a89164b-e1e9-4157-a972-956de4a83bbd", "AQAAAAEAACcQAAAAEC9hwtTPOq4VE5rc134sjsFaCRT5BAg6dnJT3noTT1Hr3gln1nSSN6oG+xmuQDsN8Q==", "559011d2-e696-4bbf-a3f1-9635492561c6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e593df0-89c0-4753-89b4-66816bde502c", "AQAAAAEAACcQAAAAEN6V67vweSFKXa/wtIbnrIBR8EWFGqa8fq16Dm9umrcqNJcBNy8HCf+UhgEtmeyiUA==", "6bc82d2a-2f94-4daf-abdf-4715c7c29160" });

            migrationBuilder.InsertData(
                table: "ProductsInCategories",
                columns: new[] { "pic_CategoriesId", "pic_productId" },
                values: new object[,]
                {
                    { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "511557c2-0003-4506-80d1-5c5332b6c58f" },
                    { "1cc98150-48a1-4783-b933-17d316906ca5", "1c16a5b8-787c-429f-8fc9-ee6b71c02d8f" },
                    { "1cc98150-48a1-4783-b933-17d316906ca5", "f06aa333-4851-4011-95c0-cda7aba28e84" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "7fbd8fce-55f0-4d87-87c7-ab0ceeb44948" },
                    { "1cc98150-48a1-4783-b933-17d316906ca5", "1c3c1297-782f-4729-a1ec-a326c91bfcbb" },
                    { "1cc98150-48a1-4783-b933-17d316906ca5", "fcf6009d-f719-402d-80ad-2d6ee8040963" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "60c0e2bb-a07b-4a03-9cd7-44226a2cda01" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "49cb5a13-cf57-423c-954b-0d95f8c69a8a" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "d80b0de3-9f4a-4482-8a54-e984aa2caed8" },
                    { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "8e28728f-725f-41f9-95be-e6e6ce83b1d6" },
                    { "c2353234-ed9e-4d4b-a087-f25a71cdcac5", "3a0e245a-d641-4ff7-b4de-c4ea64c837de" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "3497483f-ef59-4d93-b8e1-f4daf4c2ea1f" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "980b9440-4392-4f3e-a339-d943a264ba93" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "8e5769df-3c2e-4634-9d19-c732af2ad555" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "55f7b643-ebca-40e1-b592-8811ba0ae3ba" },
                    { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "94a72205-0018-457b-bc59-916c38dcb9d0" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "47c84d2e-8da9-44d1-894f-e628c3a7de4c" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "4464c176-42bc-4d8f-8ad4-9f37b50a98c7" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "3897bf54-af14-4dba-8dc5-b476a7c525cc" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "9ed428bf-1a86-41c2-90af-39f7507ca227" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "d28ca46d-4808-4f94-9564-edfab255aa8e" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "af35f87e-4dd0-4fe0-9862-62d0dee0c2fd" },
                    { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "1457e167-87bd-4555-ae4e-0b4a1448e821" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "232d9499-2e3f-490f-8541-45e08e12cc1e" },
                    { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "38748005-289d-4ef7-9a49-fa1138b6cd00" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "8d142bf2-ef31-4a24-bd9b-784612b1d77e" },
                    { "c2353234-ed9e-4d4b-a087-f25a71cdcac5", "489cd014-4707-400f-919e-4fbb346d205f" }
                });

            migrationBuilder.InsertData(
                table: "ReviewInproduct",
                columns: new[] { "rip_ProductId", "rip_ReviewId" },
                values: new object[,]
                {
                    { "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea", "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" },
                    { "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea", "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" },
                    { "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea", "EEBA6608-AB75-4E83-909F-604B1A06F16C" }
                });

            migrationBuilder.InsertData(
                table: "SubReviewInReview",
                columns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                values: new object[,]
                {
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "60b032c6-3cd1-43f8-9777-bdbe23677589" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "134597a7-e2f9-4ff7-8ec4-2890a6357981" },
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "f80033ea-49ca-477c-8f96-7aaaa96f91fb" }
                });
        }
    }
}
