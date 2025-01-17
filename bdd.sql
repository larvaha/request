SET IDENTITY_INSERT [dbo].[Role] ON 
INSERT [dbo].[Role] ([id_role], [RoleName]) VALUES (1, N'User')
INSERT [dbo].[Role] ([id_role], [RoleName]) VALUES (2, N'Ispolnytel')
INSERT [dbo].[Role] ([id_role], [RoleName]) VALUES (3, N'Manager')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO

SET IDENTITY_INSERT [dbo].[Status] ON 
INSERT [dbo].[Status] ([id_status], [StatusName]) VALUES (1, N'в ожидании')
INSERT [dbo].[Status] ([id_status], [StatusName]) VALUES (2, N'в работе')
INSERT [dbo].[Status] ([id_status], [StatusName]) VALUES (3, N'выполнено')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO

SET IDENTITY_INSERT [dbo].[User] ON 
INSERT [dbo].[User] ([id_user], [userName], [Login], [password], [RoleID], [Ispolnitel_id]) VALUES (1, N'Pasha', N'User', N'User', 1, 0)
INSERT [dbo].[User] ([id_user], [userName], [Login], [password], [RoleID], [Ispolnitel_id]) VALUES (3, N'Kirill', N'User2', N'User2', 2, 1)
INSERT [dbo].[User] ([id_user], [userName], [Login], [password], [RoleID], [Ispolnitel_id]) VALUES (10, N'Egor', N'User3', N'User3', 3, 0)
INSERT [dbo].[User] ([id_user], [userName], [Login], [password], [RoleID], [Ispolnitel_id]) VALUES (11, N'Ura', N'User4', N'User4', 2, 2)
SET IDENTITY_INSERT [dbo].[User] OFF
GO

ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Equipmnt] FOREIGN KEY([equipmentId])
REFERENCES [dbo].[Equipmnt] ([id_Equipmnt])
GO

ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Equipmnt]
GO

ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Ispolnitel] FOREIGN KEY([ispolnitelId])
REFERENCES [dbo].[Ispolnitel] ([Id_ispolnitel])
GO

ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Ispolnitel]
GO

ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_IssueType] FOREIGN KEY([IssueTypeId])
REFERENCES [dbo].[IssueType] ([id_IssueType])
GO

ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_IssueType]
GO

ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([id_status])
GO

ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Status]
GO

ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([id_role])
GO

ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO

USE [master]
GO

ALTER DATABASE [request] SET  READ_WRITE 
GO