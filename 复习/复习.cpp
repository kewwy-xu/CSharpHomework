#include<iostream>
using namespace std;
#define MAX 100
typedef struct
{
	double coef;
	int exp;
}PolyArray;
typedef struct pnode
{
	double coef;
	int exp;
	struct pnode* next;
}PolyNode;

void DispPoly(PolyNode* L)
{
	bool first = true;
	PolyNode* p = L->next;
	while (p != NULL)
	{
		if (first)  first = false;
		else if (p->coef > 0)
			cout << "+";
		 if (p->exp == 0)  cout << p->coef;
		 else if (p->exp == 1)  cout << p->coef << "x";
		else  cout << p->coef << "x^" << p->exp;
		p = p->next;
	}
	cout << endl;
}

void DestroyPoly(PolyNode* L)
{
	PolyNode* pre = L, * p = pre->next;
	while (p != NULL)
	{
		free(pre); pre = p; p = p->next;
	}
	free(pre);
}

void CreatePolyR(PolyNode*& L, PolyArray a[], int n)
{
	PolyNode* s, * r; int i;
	L = (PolyNode*)malloc(sizeof(PolyNode));
	L->next = NULL; r = L;
	for (i = 0; i < n; i++)
	{
		s= (PolyNode*)malloc(sizeof(PolyNode));
		s->coef = a[i].coef;
		s->exp = a[i].exp;
		r->next = s; r = s;
	}
	r->next = NULL;
}

void Sort(PolyNode*& L)
{
	PolyNode* p = L->next, * pre, * q;
	if (p != NULL)
	{
		q = p->next; p->next = NULL; p = q;
		while (p != NULL)
		{
			q = p->next; pre = L;
			while (pre->next != NULL && pre->next->exp > p->exp)
				pre = pre->next;
			p->next = pre->next; pre->next = p; p = q;
		}
	}
}

void Add(PolyNode* ha, PolyNode* hb, PolyNode*& hc)
{
	PolyNode* pa = ha->next, * pb = hb->next,*s, * r;
	hc= (PolyNode*)malloc(sizeof(PolyNode));
	double c; r = hc;
	while (pa != NULL && pb != NULL)
	{
		if (pa->exp > pb->exp)
		{
			s = (PolyNode*)malloc(sizeof(PolyNode));
			s->coef = pa->coef; s->exp = pa->exp;
			r->next = s; r = s; pa = pa->next;
		}
		else if (pa->exp < pb->exp)
		{
			s = (PolyNode*)malloc(sizeof(PolyNode));
			s->coef = pb->coef; s->exp = pb->exp;
			r->next = s; r = s; pb = pb->next;
		}
		else
		{
			c = pa->coef+pb->coef; 
			if (c != 0)
			{
				s = (PolyNode*)malloc(sizeof(PolyNode));
				s->coef = c; s->exp = pa->exp;
				r->next = s; r = s;
			}
			pa = pa->next; pb = pb->next;
		}
	}
	if (pb != NULL)  pa = pb;
	while(pa != NULL)
	{
		s = (PolyNode*)malloc(sizeof(PolyNode));
		s->coef = pa->coef; s->exp = pa->exp;
		r->next = s; r = s; pa = pa->next;
	}
	r->next = NULL;
}

void Mult1(PolyNode* ha, PolyNode* hb, PolyNode*& hc)
{
	PolyNode* pa = ha->next, * pb, * s, * tc;
	hc = (PolyNode*)malloc(sizeof(PolyNode));
	tc = hc;
	while (pa != NULL)
	{
		pb = hb->next;
		while (pb != NULL)
		{
			s = (PolyNode*)malloc(sizeof(PolyNode));
			s->coef = pa->coef * pb->coef;
			s->exp = pa->exp + pb->exp;
			tc->next = s; tc = s; pb = pb->next;
		}
		pa = pa->next;
	}
	tc->next = NULL;
}

void Comb(PolyNode*& L)
{
	PolyNode* pre = L->next, * p = pre->next;
	if (pre == NULL) return;
	while (p != NULL)
	{
		while (p->exp == pre->exp)
		{
			pre->coef += p->coef;
			pre->next = p->next;
			free(p); p = pre->next;
		}
		pre = p; p = p->next;
	}
}

int main()
{
	PolyNode* ha, * hb, * hc;
	PolyArray a[] = { {2,3},{1,0},{3,1} };
	PolyArray b[] = { {2,3},{-3,2},{5,4},{-3,0} };
	CreatePolyR(ha, a, 3); CreatePolyR(hb, b, 4);
	cout << "原多项式A为："; DispPoly(ha);
	cout << "原多项式B为："; DispPoly(hb);
	Sort(ha); Sort(hb);
	cout << "有序多项式A为："; DispPoly(ha);
	cout << "有序多项式B为："; DispPoly(hb);
	Mult1(ha, hb, hc); Sort(hc); Comb(hc);
	cout << "多项式相乘："; DispPoly(hc);
	DestroyPoly(ha);
	DestroyPoly(hb);
	DestroyPoly(hc);
}