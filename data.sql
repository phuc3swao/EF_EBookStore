USE [AS01_PRN231]
GO
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([Author_Id], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [EmailAddress]) VALUES (1, N'Nguyễn', N'Thị An', N'0987654321', N'123 Đường ABC', N'Hà Nội', N'TP', N'100000', N'thian.nguyen@email.com')
INSERT [dbo].[Author] ([Author_Id], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [EmailAddress]) VALUES (2, N'Trần', N'Văn Bình', N'0901234567', N'456 Đường XYZ', N'Hồ Chí Minh', N'TP', N'700000', N'binh.tran@email.com')
INSERT [dbo].[Author] ([Author_Id], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [EmailAddress]) VALUES (3, N'Lê', N'Thiện Tâm', N'0978888888', N'789 Đường DEF', N'Đà Nẵng', N'TP', N'500000', N'tam.le@email.com')
INSERT [dbo].[Author] ([Author_Id], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [EmailAddress]) VALUES (4, N'Phạm', N'Như Quỳnh', N'0961111222', N'101 Đường GHI', N'Hải Phòng', N'TP', N'200000', N'quynh.pham@email.com')
INSERT [dbo].[Author] ([Author_Id], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [EmailAddress]) VALUES (5, N'Huỳnh', N'Thị Mai', N'0943333444', N'202 Đường JKL', N'Vũng Tàu', N'TP', N'800000', N'mai.huynh@email.com')
INSERT [dbo].[Author] ([Author_Id], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [EmailAddress]) VALUES (6, N'Đinh', N'Anh Dũng', N'0955555666', N'303 Đường MNO', N'Biên Hòa', N'TN', N'600000', N'dung.dinh@email.com')
INSERT [dbo].[Author] ([Author_Id], [LastName], [FirstName], [Phone], [Address], [City], [State], [Zip], [EmailAddress]) VALUES (7, N'Võ', N'Thị Huệ', N'0937777888', N'404 Đường PQR', N'Quy Nhơn', N'BĐ', N'900000', N'hue.vo@email.com')
SET IDENTITY_INSERT [dbo].[Author] OFF
GO
SET IDENTITY_INSERT [dbo].[Publisher] ON 

INSERT [dbo].[Publisher] ([Pub_id], [Publisher_name], [City], [State], [Country]) VALUES (1, N'Nhà Xuất Bản ABC', N'Hà Nội', N'Thành phố Hà Nội', N'Việt Nam')
INSERT [dbo].[Publisher] ([Pub_id], [Publisher_name], [City], [State], [Country]) VALUES (2, N'Công Ty XYZ', N'Hồ Chí Minh', N'Thành phố Hồ Chí Minh', N'Việt Nam')
INSERT [dbo].[Publisher] ([Pub_id], [Publisher_name], [City], [State], [Country]) VALUES (3, N'Tập Đoàn Sách Vàng', N'Đà Nẵng', N'Thành phố Đà Nẵng', N'Việt Nam')
INSERT [dbo].[Publisher] ([Pub_id], [Publisher_name], [City], [State], [Country]) VALUES (4, N'NXB Trí Tuệ', N'Hải Phòng', N'Thành phố Hải Phòng', N'Việt Nam')
INSERT [dbo].[Publisher] ([Pub_id], [Publisher_name], [City], [State], [Country]) VALUES (5, N'Quốc Gia Publishing', N'Hà Nam', N'Tỉnh Hà Nam', N'Việt Nam')
INSERT [dbo].[Publisher] ([Pub_id], [Publisher_name], [City], [State], [Country]) VALUES (6, N'Nhà Xuất Bản XYZ', N'Cần Thơ', N'Thành phố Cần Thơ', N'Việt Nam')
INSERT [dbo].[Publisher] ([Pub_id], [Publisher_name], [City], [State], [Country]) VALUES (7, N'Tổ Chức Sách Trí Tuệ', N'Hà Tĩnh', N'Tỉnh Hà Tĩnh', N'Việt Nam')
INSERT [dbo].[Publisher] ([Pub_id], [Publisher_name], [City], [State], [Country]) VALUES (8, N'Độc Lập Publishing', N'Buôn Ma Thuột', N'Tỉnh Đắk Lắk', N'Việt Nam')
INSERT [dbo].[Publisher] ([Pub_id], [Publisher_name], [City], [State], [Country]) VALUES (9, N'Phương Nam Books', N'Vũng Tàu', N'Tỉnh Bà Rịa-Vũng Tàu', N'Việt Nam')
INSERT [dbo].[Publisher] ([Pub_id], [Publisher_name], [City], [State], [Country]) VALUES (10, N'Sách Đồng Nai', N'Biên Hòa', N'Tỉnh Đồng Nai', N'Việt Nam')
SET IDENTITY_INSERT [dbo].[Publisher] OFF
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (1, N'Tiếng Việt 101', N'Sách giáo trình', 1, CAST(25.99 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(0.10 AS Decimal(18, 2)), 1000, N'Sách học Tiếng Việt cơ bản', CAST(N'2024-02-15T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (2, N'Đường Con Đi Đến Hạnh Phúc', N'Tiểu thuyết', 3, CAST(29.99 AS Decimal(18, 2)), CAST(7000.00 AS Decimal(18, 2)), CAST(0.15 AS Decimal(18, 2)), 1500, N'Sách tự luyện tâm hồn', CAST(N'2024-03-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (3, N'Công Nghệ Thông Tin 2024', N'Sách chuyên ngành', 2, CAST(45.99 AS Decimal(18, 2)), CAST(8000.00 AS Decimal(18, 2)), CAST(0.12 AS Decimal(18, 2)), 2000, N'Sách về công nghệ mới nhất', CAST(N'2024-02-28T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (4, N'Bí Quyết Làm Cha Mẹ Tốt', N'Sách tự giáo dục', 5, CAST(19.99 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)), CAST(0.08 AS Decimal(18, 2)), 800, N'Sách hướng dẫn nuôi dạy con', CAST(N'2024-02-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (5, N'Dinh Dưỡng Sức Khỏe Cho Người Bận Rộn', N'Sách y tế', 4, CAST(35.99 AS Decimal(18, 2)), CAST(6000.00 AS Decimal(18, 2)), CAST(0.14 AS Decimal(18, 2)), 1200, N'Sách về dinh dưỡng và sức khỏe', CAST(N'2024-02-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (6, N'Tiếng Anh Giao Tiếp', N'Sách học ngoại ngữ', 6, CAST(28.99 AS Decimal(18, 2)), CAST(6000.00 AS Decimal(18, 2)), CAST(0.12 AS Decimal(18, 2)), 1200, N'Sách học Tiếng Anh cơ bản', CAST(N'2024-03-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (7, N'Tiếng Việt Cho Người Nước Ngoài', N'Sách học ngoại ngữ', 8, CAST(32.99 AS Decimal(18, 2)), CAST(7500.00 AS Decimal(18, 2)), CAST(0.14 AS Decimal(18, 2)), 1800, N'Sách học Tiếng Việt cho người nước ngoài', CAST(N'2024-03-10T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (8, N'Tâm Lý Học Sống Khỏe', N'Sách học tâm lý', 10, CAST(24.99 AS Decimal(18, 2)), CAST(4500.00 AS Decimal(18, 2)), CAST(0.10 AS Decimal(18, 2)), 1000, N'Sách về tâm lý và tư duy tích cực', CAST(N'2024-03-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (9, N'Trí Tuệ Nhân Tạo Đại Cương', N'Sách chuyên ngành', 7, CAST(49.99 AS Decimal(18, 2)), CAST(9000.00 AS Decimal(18, 2)), CAST(0.18 AS Decimal(18, 2)), 2500, N'Sách về trí tuệ nhân tạo', CAST(N'2024-03-15T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (10, N'Mỹ Thuật Ẩm Thực', N'Sách nghệ thuật', 9, CAST(39.99 AS Decimal(18, 2)), CAST(8000.00 AS Decimal(18, 2)), CAST(0.16 AS Decimal(18, 2)), 2000, N'Sách về nghệ thuật ẩm thực', CAST(N'2024-03-08T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (11, N'Khoa Học Tự Nhiên 2024', N'Sách giáo trình', 5, CAST(27.99 AS Decimal(18, 2)), CAST(5500.00 AS Decimal(18, 2)), CAST(0.11 AS Decimal(18, 2)), 1100, N'Sách học Khoa Học Tự Nhiên', CAST(N'2024-03-18T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (12, N'Thế Giới Kỳ Thú', N'Sách khoa học', 3, CAST(34.99 AS Decimal(18, 2)), CAST(6800.00 AS Decimal(18, 2)), CAST(0.13 AS Decimal(18, 2)), 1600, N'Sách về các hiện tượng kỳ thú trên thế giới', CAST(N'2024-03-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (13, N'Marketing Chiến Lược', N'Sách kinh doanh', 8, CAST(42.99 AS Decimal(18, 2)), CAST(7800.00 AS Decimal(18, 2)), CAST(0.16 AS Decimal(18, 2)), 1900, N'Sách hướng dẫn chiến lược tiếp thị', CAST(N'2024-03-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (14, N'Du Lịch Nước Ngoài', N'Sách du lịch', 2, CAST(29.99 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(0.12 AS Decimal(18, 2)), 1300, N'Sách hướng dẫn du lịch nước ngoài', CAST(N'2024-03-28T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (15, N'Trẻ Hóa Tinh Thần', N'Sách sức khỏe', 1, CAST(36.99 AS Decimal(18, 2)), CAST(6500.00 AS Decimal(18, 2)), CAST(0.14 AS Decimal(18, 2)), 1700, N'Sách về cách trẻ hóa tinh thần', CAST(N'2024-03-30T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (16, N'Đồng Cảm Với Thiên Nhiên', N'Sách môi trường', 9, CAST(31.99 AS Decimal(18, 2)), CAST(6000.00 AS Decimal(18, 2)), CAST(0.13 AS Decimal(18, 2)), 1400, N'Sách về bảo vệ môi trường', CAST(N'2024-03-22T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (17, N'Suối Ngọc Tình Thần', N'Tiểu thuyết', 4, CAST(22.99 AS Decimal(18, 2)), CAST(4800.00 AS Decimal(18, 2)), CAST(0.10 AS Decimal(18, 2)), 1000, N'Truyện ngắn về tình yêu và tinh thần', CAST(N'2024-04-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (18, N'Nghệ Thuật Sáng Tạo', N'Sách nghệ thuật', 6, CAST(39.99 AS Decimal(18, 2)), CAST(7000.00 AS Decimal(18, 2)), CAST(0.15 AS Decimal(18, 2)), 1600, N'Sách về nghệ thuật sáng tạo', CAST(N'2024-04-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (19, N'Thế Giới Ẩm Thực', N'Sách du lịch', 7, CAST(26.99 AS Decimal(18, 2)), CAST(5500.00 AS Decimal(18, 2)), CAST(0.11 AS Decimal(18, 2)), 1200, N'Sách khám phá ẩm thực thế giới', CAST(N'2024-04-08T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (20, N'Quản Lý Dự Án Hiệu Quả', N'Sách kinh doanh', 1, CAST(45.99 AS Decimal(18, 2)), CAST(8000.00 AS Decimal(18, 2)), CAST(0.17 AS Decimal(18, 2)), 2100, N'Sách hướng dẫn quản lý dự án', CAST(N'2024-04-10T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (21, N'Dấu Ấn Lịch Sử', N'Tiểu thuyết lịch sử', 9, CAST(32.99 AS Decimal(18, 2)), CAST(6000.00 AS Decimal(18, 2)), CAST(0.13 AS Decimal(18, 2)), 1400, N'Sách kể về những sự kiện lịch sử', CAST(N'2024-04-15T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (22, N'Yoga Cho Sức Khỏe', N'Sách sức khỏe', 3, CAST(29.99 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(0.12 AS Decimal(18, 2)), 1300, N'Sách hướng dẫn thực hành yoga', CAST(N'2024-04-18T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Books] ([Bookid], [Title], [Type], [Pub_id], [Price], [Advance], [Royalty], [Ytd_sales], [Notes], [Published_date]) VALUES (23, N'Kỹ Năng Giao Tiếp Hiệu Quả', N'Sách phát triển bản thân', 5, CAST(20.99 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), CAST(0.09 AS Decimal(18, 2)), 900, N'Sách hướng dẫn kỹ năng giao tiếp', CAST(N'2024-04-20T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (1, 2, 3, 8, 1, 2)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (1, 9, 3, 14, 1, 9)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (2, 5, 2, 15, 2, 5)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (2, 14, 2, 10, 2, 14)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (3, 6, 1, 8, 3, 6)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (3, 10, 1, 12, 3, 10)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (3, 18, 1, 15, 3, 18)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (4, 7, 2, 14, 4, 7)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (4, 8, 1, 14, 4, 8)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (5, 12, 2, 10, 5, 12)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (5, 16, 2, 15, 5, 16)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (6, 3, 3, 12, 6, 3)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (6, 19, 2, 18, 6, 19)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (7, 15, 3, 10, 7, 15)
INSERT [dbo].[BookAuthor] ([Author_id], [Book_id], [Author_order], [Royality_percentage], [authorid], [bookid]) VALUES (7, 22, 1, 12, 7, 22)
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Role_Id], [Role_desc]) VALUES (1, N'admin')
INSERT [dbo].[Role] ([Role_Id], [Role_desc]) VALUES (2, N'user')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230619161045_InitialDB', N'6.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230620040204_FixUser', N'6.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230620040916_FixUsersA', N'6.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240222064709_DB2024', N'6.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240222065338_DV2024', N'6.0.18')
GO
