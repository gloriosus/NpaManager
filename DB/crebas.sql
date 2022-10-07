/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* ������� ������� ��� ����                                     */
/* Created on:     27.04.2015 21:44:47                          */
/*==============================================================*/


alter table dbo.IogvRef
   add ParentIogv varchar(512)         null
go

alter table dbo.IogvRef
   add constraint IogvRef_IogvRef foreign key (ParentIogv)
      references dbo.IogvRef (Iogv)
         on update cascade on delete cascade
go

Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ������������� ���', null);
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������� ����������� � ������������� ���', null);
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������ �������������� ������, ����������� �������������� ���', null);
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������������� ������������� ��� ��� ������������� ��', null);

Insert into IogvRef ([Iogv],[ParentIogv]) Values('���� ���', null);
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��� ���', '���� ���');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ��� ���', '���� ���');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('�������������� �������� ���', '���� ���');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('�������������� ����������� ������� ���', '���� ���');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������� ����� ���', '���� ���');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����� ��������� ������������ � ���', '���� ���');

Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������������ ������', null);
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ���', '������������������ ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������ ���������� ������������� �������� �� �� ���', '������������������ ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ������ �����������', '������������������ ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ������������ ���������� ��� �� �� ���', '������������������ ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������������� ��������� ������������ ��������� �������� ���� �� �� ���', '������������������ ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����� ����������� ������������ ������ ������  �� ���', '������������������ ������');

Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������������� ������ �������������� ������', null);
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������� ����������� ��������� �� ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������� ���������� ��� ������ �� ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������������� ������������ ����������� ��� �� � �. ����������', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������� ����������� ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����� �� ��������� ���������� ������� �������� ���������� ������� ������ �� ������������ ���� � ��������� ���������� �������', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ����������� ������ ���������� ��������� �� ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ����������� ������ �������� ��������� �� ��� ', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����� ��������������� �������������� ������ �� � �. ����������� (����� ��� ������ � �. �����������)', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ����������� ������ ������������ �� �� ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������ � �. ����������� ������������ ���������� ����������� ������ ������������ ���������� ��������� �� ������������ ���� � ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������ �� ��� ������������� ���������� ����������� ������ �� �� �������� �� �������� ���������� �� ������������ ���� (������ �� ��� ������ �� �� ������������ ����)', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����� ����������� ����� � ���������� ����������� ������ ������ �� � ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ����������� ������ �� ������� � ����� ������ ���� ������������ � ������������ �������� �� ��� (���������� ���������������� �� ���)', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������������� ����� ����������� ������ �� ������� � ����� ��������������� �� ��������� ���������� ������� (���������� ��������������� �� ���)', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������������� ��������� ����� � ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ����������� ������ �� ������� � ����� ������������������ (���������������) �� ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� �� ���������������� �� ��� (��������)', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����� ������ �������� �� ��� ��������� ������������ ������� ���������� ������������ ��������� ������ ��������', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ����������� ������ �� ������� � ����� �����, �������������� ���������� � �������� ������������ �� ���������������� ������������ ������', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('�������������� ��������������� ����� (���������� ������������� �� ������������ ���� � ���)', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ����������� ������ �� ������������� � ��������������� ������� �� ������������ ���� � ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������������� ����� �� ��������� ���������� ������� ���������������� ���������������� ���������� ���������������� ������������� �������', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ����������� ��������� ������ �� ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������� ���������� ������������ ����� �� �� ��� (�� ����� ������ �� ���)', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����� �� ��������� ���������� ������� ���������������� ���������������� ���������� ����������� ������ ���������-���������� ������� � ����������� ����', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ������������ ������������ �� ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������������� ����� ����������� ������ ��������������� ���������� �� ��� (�������)', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������������� ���������� ������������ ��������� �� ���������� ��������������� ���������� �� ��� (�� ������������ �� ���)', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ����������� ������ ��������������� �����������, �������� � ����������� �� ���', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ����������� ��������������� ������ �� ��� (��������� ���� ������)', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('�������������� �������', '��������������� ������ �������������� ������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('�������������� ����� �� ������� �� ������������ � �������������� ������������� ���������������� ���������� �������������', '��������������� ������ �������������� ������');

Insert into IogvRef ([Iogv],[ParentIogv]) Values('�����', null);
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������������� ���������� � ��������� ����������� ����� �� �� ���', '�����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������������� ���������� � ������������ ��������� ����� ����������� ����������� �� �� ���', '�����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������������� ���� ������������� ������������ ����������� ���', '�����');

Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ��������� ����������', null);
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ��������������� ��������� ���������� ����������� ���������� ������ � ��������������������� ������������� �� ��λ (����������������������)�', '����������� ��������� ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ��������� ���������� ���������������� ������������ ����� ��������������, ���������� � ��������� � ��������� ���������� ������� (��� ���� ��λ)', '����������� ��������� ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ����������� �������� ����� ��� � ������ ���� ������ ������', '����������� ��������� ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������ ���� ����� ��������������� ������������� � ���������������� �������� ����� (���� �����)', '����������� ��������� ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������ ������������ ���������������� ���������� ���������� ������������ ����������� ������ ����������� ������ ��������������� �����������, �������� � ����������� �� ���', '����������� ��������� ����������');

Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������� ����������� � ����������', null);
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������� ���������� ���', '��������� ����������� � ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������� ��������������� �������� ���������� ���������������� ����� ��λ', '��������� ����������� � ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���� ������ �� ����������� ���������� ��� � �������� ����������� �������, ������ ��������� � ���������� �� ������������ �������� � �������� ������������', '��������� ����������� � ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������� ��������������� �������� ���������� ����������� ����������������� ��������', '��������� ����������� � ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������� ��������������� ���������� ���������� ������������� ��� ������������', '��������� ����������� � ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������� ��������������� �������� ���������� ����������������� ����������� ������� �������������� ������ ��λ', '��������� ����������� � ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������� ��������������� �������� ���������� ���������������� ����������� ���� ��λ', '��������� ����������� � ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ������ ���', '��������� ����������� � ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������ ������ ���', '��������� ����������� � ����������');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� ������ ������������� ����������� ��λ', '��������� ����������� � ����������');

Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������� (����� ������) ������������� ����������� ���', null);
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����� ������ �����������', '');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������� ������������� �����', '������������� (����� ������) ������������� ����������� ���');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������� ��������������� �������������� ������', '������������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� �������� ���������', '������������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������ �������� ���������', '������������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������ �������� ���������', '������������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������� �������� ���������', '������������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������ �������� ���������', '������������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������� �������� ���������', '������������� ������������� �����');

Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������� ������������� �����', '������������� (����� ������) ������������� ����������� ���');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������� ���������� �������������� ������', '��������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������� �������� ���������', '��������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� �������� ���������', '��������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� �������� ���������', '��������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� �������� ���������', '��������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� �������� ���������', '��������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������ ������������� �����', '������������� (����� ������) ������������� ����������� ���');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������� ������������� �������������� ������', '������������ ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������ ��������� ���������', '������������ ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������ ��������� ���������', '������������ ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������ ��������� ���������', '������������ ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ��������� ���������', '������������ ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������ �������� ���������', '������������ ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� �������� ���������', '������������ ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ������������� �����', '������������� (����� ������) ������������� ����������� ���');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������� ������������ �������������� ������', '����������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ��������� ���������', '����������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������� ��������� ���������', '����������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ��������� ���������', '����������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ��������� ���������', '����������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������� ��������� ���������', '����������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������� ��������� ���������', '����������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('���������� �������� ���������', '����������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� ������������� �����', '������������� (����� ������) ������������� ����������� ���');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('������������� ������������ �������������� ������', '����������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� �������� ���������', '����������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('��������� �������� ���������', '����������� ������������� �����');
Insert into IogvRef ([Iogv],[ParentIogv]) Values('����������� �������� ���������', '����������� ������������� �����');
