--
-- Copyright (c) Microsoft Corporation. All rights reserved. 
-- Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
--
CREATE TABLE [dbo].[ReferralVectors]
(
	[Id] [int] NOT NULL identity(0, 1),
	[Name] [nvarchar](50) NOT NULL
 CONSTRAINT [PrimaryKey_8099F640-04F5-4342-BA6B-DAFEDA4265B1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO