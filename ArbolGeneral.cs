 using System;
using System.Collections.Generic;

namespace juegoIA
{
	public class ArbolGeneral<T>
	{
		
		private NodoGeneral<T> raiz;

		public ArbolGeneral(T dato) {
			this.raiz = new NodoGeneral<T>(dato);
		}
	
		private ArbolGeneral(NodoGeneral<T> nodo) {
			this.raiz = nodo;
		}
	
		private NodoGeneral<T> getRaiz() {
			return raiz;
		}
	
		public T getDatoRaiz() {
			return this.getRaiz().getDato();
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			List<ArbolGeneral<T>> temp= new List<ArbolGeneral<T>>();
			foreach (var element in this.raiz.getHijos()) {
				temp.Add(new ArbolGeneral<T>(element));
			}
			return temp;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.raiz.getHijos().Add(hijo.getRaiz());
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.raiz.getHijos().Remove(hijo.getRaiz());
		}
	
		public bool esVacio() {
			return this.raiz == null;
		}
	
		public bool esHoja() {
			return this.raiz != null && this.getHijos().Count == 0;
		}
	
		public int altura() {
			return 0;
		}
		
			public void consultaProfundidad(int profundidad){
			int contador=0;
			if (profundidad==0){
				Console.WriteLine("No hay jugadas para mostrar");
			}else{
				if(contador<profundidad){
				contador++;
				Console.WriteLine(this.getDatoRaiz());
				List<ArbolGeneral<T>> hijos= this.getHijos();
				foreach(ArbolGeneral<T> arbol in hijos){
					arbol.consultaProfundidad(profundidad);
				}
					}
			}
		}
		
		public void consultaNiveles(){
			Cola<NodoGeneral<T>> cola= new Cola<NodoGeneral<T>>(); 
			cola.encolar(this.getRaiz);
			while(!cola.esVacia()){
				cola.desencolar();
				Console.WriteLine(" "+ raiz.getDato);
				List<NodoGeneral<T>> nodos= raiz.getHijos();
				foreach(NodoGeneral<T> nodo in nodos){
					cola.encolar(nodo);
				}
				
								
				
				
			}
				
		
		}
	
		
		public int nivel(T dato) {
			return 0;
		}
	
	}
}