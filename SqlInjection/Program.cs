using System;
using System.Data.SqlClient;

namespace SqlInjection
{
    class Program
    {
        /*
         * 
         * 
         * SQL SCRIPT:CREATE TABLE CATEGORIES AND INSERT SOME ROWS
         * 
         * 
		 * CREATE TABLE [dbo].[CATEGORIES](
	[CATEGORY_ID] [int] IDENTITY(1,1) NOT NULL,
	[CATEGORY_NAME] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CATEGORY_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CATEGORIES] ON 
GO
INSERT [dbo].[CATEGORIES] ([CATEGORY_ID], [CATEGORY_NAME]) VALUES (1, N'Sports')
GO
INSERT [dbo].[CATEGORIES] ([CATEGORY_ID], [CATEGORY_NAME]) VALUES (2, N'Actualités')
GO
INSERT [dbo].[CATEGORIES] ([CATEGORY_ID], [CATEGORY_NAME]) VALUES (3, N'Animaux')
GO
INSERT [dbo].[CATEGORIES] ([CATEGORY_ID], [CATEGORY_NAME]) VALUES (4, N'Economie')
GO
INSERT [dbo].[CATEGORIES] ([CATEGORY_ID], [CATEGORY_NAME]) VALUES (5, N'Cuisine')
GO
SET IDENTITY_INSERT [dbo].[CATEGORIES] OFF
GO
		 */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name ");
            string categoryName = Console.ReadLine();
            string connectionString = "Data Source=DESKTOP-IT7FSGA;Initial Catalog=KIGO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";//put the connection string to the database
            categoryName = "economie' OR 'a'='a"; //but, the hacker introduce this text and he gets all rows
            string select = "select * from dbo.CATEGORIES where CATEGORY_NAME='" + categoryName + "'";


            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(select, sqlConnection))
                {

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(1));
                    }
                }

            }
        }
    }
}
