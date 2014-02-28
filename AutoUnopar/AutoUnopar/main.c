#include <stdio.h>

struct Tv {
	int ID;
	int Tamanho;
	int Volume;

};

typedef struct {
	int ID;
	int Potencia;
	int Temperatura;
} ArCondicionado;

void main() {
	struct Tv tv1, tv2;
	tv1.ID = 1;
	tv2.ID = 2;

	ligarTv(tv1);
}

void ligarTv(struct Tv tv) {
	printf("A Tv %d foi ligada", tv.ID);
}

void desligarTv(struct Tv tv) {
	printf("A Tv %d foi desligada", tv.ID);
}

void volumeMaisTv(struct Tv tv) {
	if (tv.Volume < 100) {
		tv.Volume++;
	}
	printf("Tv %d Volume %d", tv.ID, tv.Volume);
}

void volumeMenosTv(struct Tv tv) {
	if (tv.Volume > 0) {
		tv.Volume--;
	}
	printf("Tv %d Volume %d", tv.ID, tv.Volume);
}

void ligarAC(ArCondicionado ac) {
	printf("O AC %d foi ligado", ac.ID);
}

void desligarAC(ArCondicionado ac) {
	printf("O AC %d foi desligado", ac.ID);
}

void temperaturaMaisAC(ArCondicionado ac) {
	if (ac.Temperatura < 25) {
		ac.Temperatura++;
	}
	printf("AC %d Temp. %d", ac.ID, ac.Temperatura);
}

void temperaturaMenosAC(ArCondicionado ac) {
	if (ac.Temperatura > 15) {
		ac.Temperatura--;
	}
	printf("AC %d Temp. %d", ac.ID, ac.Temperatura);
}