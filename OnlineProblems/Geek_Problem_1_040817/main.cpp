#include <iostream>
#include <vector>
#include <conio.h>
using namespace std;

int main()
{
	int numTestCases, num, act, index;
	long query;
	

	cin >> numTestCases;
	for (int i = 1; i <= numTestCases; i++)
	{
		cin >> num >> query;
		vector<int> unread, read, trash;
		vector<int>::iterator pd;

		for (int i = 1
			; i <= num; i++)
			unread.push_back(i);

		for (long j = 1; j <= query; j++)
		{
			cin >> act >> index;
			if (act == 1)
			{
				for(pd = unread.begin(); pd!=unread.end(); pd++)
					if (*pd == index)
					{
						unread.erase(pd);
						read.push_back(index);
						break;
					}
			}
			if (act == 2)
			{
				for (pd = read.begin(); pd != read.end(); pd++)
					if (*pd == index)
					{
						read.erase(pd);
						trash.push_back(index);
						break;
					}
			}
			if (act == 3)
			{
				for (pd = unread.begin(); pd != unread.end(); pd++)
					if (*pd == index)
					{
						unread.erase(pd);
						trash.push_back(index);
						break;
					}
			}
			if (act == 4)
			{
				for (pd = trash.begin(); pd != trash.end(); pd++)
					if (*pd == index)
					{
						trash.erase(pd);
						read.push_back(index);
						break;
					}
			}
		}
		if (unread.size())
		{
			for (pd = unread.begin(); pd != unread.end(); pd++)
				cout << *pd << " ";
			cout << endl;
		}
		else
			cout << "EMPTY" << endl;

		if (read.size())
		{
			for (pd = read.begin(); pd != read.end(); pd++)
				cout << *pd << " ";
			cout << endl;
		}
		else
			cout << "EMPTY" << endl;

		if (trash.size())
		{
			for (pd = trash.begin(); pd != trash.end(); pd++)
				cout << *pd << " ";
			cout << endl;
		}
		else
			cout << "EMPTY" << endl;
		cout << unread.size() << " " << read.size() << " " << trash.size() << endl;
	}

	

	_getch();
}