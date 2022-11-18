
create table [Item](
	[ItemID] [numeric](4, 0) primary key, 
	[ItemName] [varchar](30) ,
	[Size] [varchar] (15) , 
	)
	go

	
	

create table [Agent](
	[AgenID] [numeric](4, 0) primary key,
	[AgentName] [varchar](30),
	[Address] [varchar](30),
)
	go
	
	
	

create table [Order](
	[OrderID] [numeric](4, 0) primary key,
	[OrderDate] [Datetime],
	[AgenID] [numeric](4, 0),
)

	go

create table [OderDetail](
	[ID] [numeric](4, 0) primary key,
	[OrderID] [numeric](4, 0),
	[ItemID] [numeric](4, 0),
	[Quantity] [varchar](15),
	[UnitAmount] [numeric](4, 0),

)
	go


INSERT [Item] ([ItemID], [ItemName], [Size]) values (CAST(1 AS Numeric(4, 0)),1,N'AB')
INSERT [Item] ([ItemID], [ItemName], [Size]) values (CAST(2 AS Numeric(4, 0)),2,N'BC')
INSERT [Item] ([ItemID], [ItemName], [Size]) values (CAST(3 AS Numeric(4, 0)),3,N'CD')
INSERT [Item] ([ItemID], [ItemName], [Size]) values (CAST(4 AS Numeric(4, 0)),4,N'DE')
INSERT [Item] ([ItemID], [ItemName], [Size]) values (CAST(5 AS Numeric(4, 0)),5,N'EF')


Insert [Agent] ([AgenID], [AgentName], [Address]) values(CAST(1 AS Numeric(4, 0)), N'ABC','Q1')
Insert [Agent] ([AgenID], [AgentName], [Address]) values(CAST(2 AS Numeric(4, 0)), N'BCD','Q2')
Insert [Agent] ([AgenID], [AgentName], [Address]) values(CAST(3 AS Numeric(4, 0)), N'CDE','Q3')
Insert [Agent] ([AgenID], [AgentName], [Address]) values(CAST(4 AS Numeric(4, 0)), N'DEF','Q4')
Insert [Agent] ([AgenID], [AgentName], [Address]) values(CAST(5 AS Numeric(4, 0)), N'EFG','Q5')


Insert [Order] ([OrderID], [OrderDate], [AgenID]) values(CAST(1 AS Numeric(4, 0)), CAST(N'2000-06-19T00:00:00.000' AS DateTime),CAST(1 AS Numeric(4, 0)))
Insert [Order] ([OrderID], [OrderDate], [AgenID]) values(CAST(2 AS Numeric(4, 0)), CAST(N'2000-01-01T00:00:00.000' AS DateTime),CAST(2 AS Numeric(4, 0)))
Insert [Order] ([OrderID], [OrderDate], [AgenID]) values(CAST(3 AS Numeric(4, 0)), CAST(N'2000-03-30T00:00:00.000' AS DateTime),CAST(3 AS Numeric(4, 0)))
Insert [Order] ([OrderID], [OrderDate], [AgenID]) values(CAST(5 AS Numeric(4, 0)), CAST(N'2000-09-29T00:00:00.000' AS DateTime),CAST(5 AS Numeric(4, 0)))
Insert [Order] ([OrderID], [OrderDate], [AgenID]) values(CAST(4 AS Numeric(4, 0)), CAST(N'2000-01-29T00:00:00.000' AS DateTime),CAST(4 AS Numeric(4, 0)))


Insert [OderDetail] ([ID], [OrderID], [ItemID], [Quantity], [UnitAmount]) values(CAST(1 AS Numeric(4, 0)), CAST(1 AS Numeric(4, 0)), CAST(1 AS Numeric(4, 0)),5, CAST(1 AS Numeric(4, 0)))
Insert [OderDetail] ([ID], [OrderID], [ItemID], [Quantity], [UnitAmount]) values(CAST(2 AS Numeric(4, 0)), CAST(2 AS Numeric(4, 0)), CAST(1 AS Numeric(4, 0)),6, CAST(2 AS Numeric(4, 0)))
Insert [OderDetail] ([ID], [OrderID], [ItemID], [Quantity], [UnitAmount]) values(CAST(3 AS Numeric(4, 0)), CAST(3 AS Numeric(4, 0)), CAST(1 AS Numeric(4, 0)),7, CAST(3 AS Numeric(4, 0)))
Insert [OderDetail] ([ID], [OrderID], [ItemID], [Quantity], [UnitAmount]) values(CAST(4 AS Numeric(4, 0)), CAST(4 AS Numeric(4, 0)), CAST(1 AS Numeric(4, 0)),8, CAST(4 AS Numeric(4, 0)))
Insert [OderDetail] ([ID], [OrderID], [ItemID], [Quantity], [UnitAmount]) values(CAST(5 AS Numeric(4, 0)), CAST(5 AS Numeric(4, 0)), CAST(1 AS Numeric(4, 0)),9, CAST(5 AS Numeric(4, 0)))

Select * From [Item]
Select * From [Agent]
Select * From [Order]                                                      
Select * From [OderDetail]