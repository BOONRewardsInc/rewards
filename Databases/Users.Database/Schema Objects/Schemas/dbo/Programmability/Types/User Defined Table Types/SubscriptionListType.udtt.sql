--
-- Copyright (c) Microsoft Corporation. All rights reserved. 
-- Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
--
CREATE TYPE [dbo].[SubscriptionListType] AS TABLE
	(LocationId			nvarchar(200), 		
	IsActive				bit)
GO
	