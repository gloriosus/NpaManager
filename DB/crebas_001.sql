/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* ������� ������� ��� ����                                     */
/* Created on:     27.04.2015 21:44:47                          */
/*==============================================================*/

alter table dbo.IogvRef
   add IogvIdx int         null default 1;
go

alter table dbo.IogvRef
   add ParentIogv varchar(512)         null
go

alter table dbo.IogvRef
   add constraint IogvRef_IogvRef foreign key (ParentIogv)
      references dbo.IogvRef (Iogv)
         on update cascade on delete cascade
go

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ������������� ���', null, 1);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������� ����������� � ������������� ���', null, 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� �� ���������� ������� �������� ����������� � ������������� ���', '������� ����������� � ������������� ���', 9);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� �����-������ �����������', '������� ����������� � ������������� ���', 10);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������ �������������� ������, ����������� �������������� ���', null, 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������������� ������������� ��� ��� ������������� ��', null, 4);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���� ���', null, 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��� ���', '���� ���', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ��� ���', '���� ���', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('�������������� �������� ���', '���� ���', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('�������������� ����������� ������� ���', '���� ���', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������� ����� ���', '���� ���', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����� ��������� ������������ � ���', '���� ���', 6);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������������ ������', null,6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ���', '������������������ ������', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������ ���������� ������������� �������� �� �� ���', '������������������ ������', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ������ �����������', '������������������ ������', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ������������ ���������� ��� �� �� ���', '������������������ ������', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������������� ��������� ������������ ��������� �������� ���� �� �� ���', '������������������ ������', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����� ����������� ������������ ������ ������  �� ���', '������������������ ������', 6);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������������� ������ �������������� ������', null, 7);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������� ����������� ��������� �� ���', '��������������� ������ �������������� ������', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������� ���������� ��� ������ �� ���', '��������������� ������ �������������� ������', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������������� ������������ ����������� ��� �� � �. ����������', '��������������� ������ �������������� ������', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������� ����������� ���', '��������������� ������ �������������� ������', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����� �� ��������� ���������� ������� �������� ���������� ������� ������ �� ������������ ���� � ��������� ���������� �������', '��������������� ������ �������������� ������', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ����������� ������ ���������� ��������� �� ���', '��������������� ������ �������������� ������', 6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ����������� ������ �������� ��������� �� ��� ', '��������������� ������ �������������� ������', 7);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����� ��������������� �������������� ������ �� � �. ����������� (����� ��� ������ � �. �����������)', '��������������� ������ �������������� ������', 8);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ����������� ������ ������������ �� �� ���', '��������������� ������ �������������� ������', 9);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������ � �. ����������� ������������ ���������� ����������� ������ ������������ ���������� ��������� �� ������������ ���� � ���', '��������������� ������ �������������� ������', 10);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������ �� ��� ������������� ���������� ����������� ������ �� �� �������� �� �������� ���������� �� ������������ ���� (������ �� ��� ������ �� �� ������������ ����)', '��������������� ������ �������������� ������', 11);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����� ����������� ����� � ���������� ����������� ������ ������ �� � ���', '��������������� ������ �������������� ������', 12);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ����������� ������ �� ������� � ����� ������ ���� ������������ � ������������ �������� �� ��� (���������� ���������������� �� ���)', '��������������� ������ �������������� ������', 13);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������������� ����� ����������� ������ �� ������� � ����� ��������������� �� ��������� ���������� ������� (���������� ��������������� �� ���)', '��������������� ������ �������������� ������', 14);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������������� ��������� ����� � ���', '��������������� ������ �������������� ������', 15);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ����������� ������ �� ������� � ����� ������������������ (���������������) �� ���', '��������������� ������ �������������� ������', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� �� ���������������� �� ��� (��������)', '��������������� ������ �������������� ������', 17);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����� ������ �������� �� ��� ��������� ������������ ������� ���������� ������������ ��������� ������ ��������', '��������������� ������ �������������� ������', 18);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ����������� ������ �� ������� � ����� �����, �������������� ���������� � �������� ������������ �� ���������������� ������������ ������', '��������������� ������ �������������� ������', 19);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('�������������� ��������������� ����� (���������� ������������� �� ������������ ���� � ���)', '��������������� ������ �������������� ������', 20);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ����������� ������ �� ������������� � ��������������� ������� �� ������������ ���� � ���', '��������������� ������ �������������� ������', 21);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������������� ����� �� ��������� ���������� ������� ���������������� ���������������� ���������� ���������������� ������������� �������', '��������������� ������ �������������� ������', 22);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ����������� ��������� ������ �� ���', '��������������� ������ �������������� ������', 23);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������� ���������� ������������ ����� �� �� ��� (�� ����� ������ �� ���)', '��������������� ������ �������������� ������', 24);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����� �� ��������� ���������� ������� ���������������� ���������������� ���������� ����������� ������ ���������-���������� ������� � ����������� ����', '��������������� ������ �������������� ������', 25);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ������������ ������������ �� ���', '��������������� ������ �������������� ������', 26);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������������� ����� ����������� ������ ��������������� ���������� �� ��� (�������)', '��������������� ������ �������������� ������', 27);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������������� ���������� ������������ ��������� �� ���������� ��������������� ���������� �� ��� (�� ������������ �� ���)', '��������������� ������ �������������� ������', 28);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ����������� ������ ��������������� �����������, �������� � ����������� �� ���', '��������������� ������ �������������� ������', 29);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ����������� ��������������� ������ �� ��� (��������� ���� ������)', '��������������� ������ �������������� ������', 30);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('�������������� �������', '��������������� ������ �������������� ������', 31);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('�������������� ����� �� ������� �� ������������ � �������������� ������������� ���������������� ���������� �������������', '��������������� ������ �������������� ������', 32);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('�����', null, 8);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������������� ���������� � ��������� ����������� ����� �� �� ���', '�����', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������������� ���������� � ������������ ��������� ����� ����������� ����������� �� �� ���', '�����', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������������� ���� ������������� ������������ ����������� ���', '�����', 3);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ��������� ����������', null, 9);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ��������������� ��������� ���������� ����������� ���������� ������ � ��������������������� ������������� �� ��λ (����������������������)�', '����������� ��������� ����������', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ��������� ���������� ���������������� ������������ ����� ��������������, ���������� � ��������� � ��������� ���������� ������� (��� ���� ��λ)', '����������� ��������� ����������', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ����������� �������� ����� ��� � ������ ���� ������ ������', '����������� ��������� ����������', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������ ���� ����� ��������������� ������������� � ���������������� �������� ����� (���� �����)', '����������� ��������� ����������',4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������ ������������ ���������������� ���������� ���������� ������������ ����������� ������ ����������� ������ ��������������� �����������, �������� � ����������� �� ���', '����������� ��������� ����������', 5);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������� ����������� � ����������', null, 10);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������� ���������� ���', '��������� ����������� � ����������', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������� ��������������� �������� ���������� ���������������� ����� ��λ', '��������� ����������� � ����������', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���� ������ �� ����������� ���������� ��� � �������� ����������� �������, ������ ��������� � ���������� �� ������������ �������� � �������� ������������', '��������� ����������� � ����������', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������� ��������������� �������� ���������� ����������� ����������������� ��������', '��������� ����������� � ����������', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������� ��������������� ���������� ���������� ������������� ��� �����������', '��������� ����������� � ����������', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������� ��������������� �������� ���������� ����������������� ����������� ������� �������������� ������ ��λ', '��������� ����������� � ����������', 6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������� ��������������� �������� ���������� ���������������� ����������� ���� ��λ', '��������� ����������� � ����������', 7);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ������ ���', '��������� ����������� � ����������', 8);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������ ������ ���', '��������� ����������� � ����������', 9);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� ������ ������������� ����������� ��λ', '��������� ����������� � ����������', 10);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������� (����� ������) ������������� ����������� ���', null, 11);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����� ������ �����������', '������������� (����� ������) ������������� ����������� ���', 1);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������� ������������� �����', '������������� (����� ������) ������������� ����������� ���', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������� ��������������� �������������� ������', '������������� ������������� �����', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� �������� ���������', '������������� ������������� �����', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������ �������� ���������', '������������� ������������� �����', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������ �������� ���������', '������������� ������������� �����', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������� �������� ���������', '������������� ������������� �����', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������ �������� ���������', '������������� ������������� �����', 6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������� �������� ���������', '������������� ������������� �����', 7);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������� ������������� �����', '������������� (����� ������) ������������� ����������� ���', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������� ���������� �������������� ������', '��������� ������������� �����', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������� �������� ���������', '��������� ������������� �����', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� �������� ���������', '��������� ������������� �����', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� �������� ���������', '��������� ������������� �����', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� �������� ���������', '��������� ������������� �����', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� �������� ���������', '��������� ������������� �����', 6);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������ ������������� �����', '������������� (����� ������) ������������� ����������� ���', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������� ������������� �������������� ������', '������������ ������������� �����', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������ ��������� ���������', '������������ ������������� �����', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������ ��������� ���������', '������������ ������������� �����', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������ ��������� ���������', '������������ ������������� �����', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ��������� ���������', '������������ ������������� �����', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������ �������� ���������', '������������ ������������� �����', 6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� �������� ���������', '������������ ������������� �����', 7);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ������������� �����', '������������� (����� ������) ������������� ����������� ���', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������� ������������ �������������� ������', '����������� ������������� �����', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ��������� ���������', '����������� ������������� �����', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������� ��������� ���������', '����������� ������������� �����', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ��������� ���������', '����������� ������������� �����', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ��������� ���������', '����������� ������������� �����', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������� ��������� ���������', '����������� ������������� �����', 6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������� ��������� ���������', '����������� ������������� �����', 7);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('���������� �������� ���������', '����������� ������������� �����', 8);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� ������������� �����', '������������� (����� ������) ������������� ����������� ���', 6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('������������� ������������ �������������� ������', '����������� ������������� �����', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� �������� ���������', '����������� ������������� �����', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('��������� �������� ���������', '����������� ������������� �����', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('����������� �������� ���������', '����������� ������������� �����', 4);
