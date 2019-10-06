package jsonGen;

import java.util.Scanner;

public class JSONGenerator {
	
	private static final int NUM_ENTRIES = 1000;
	public static void main(String[] args) {
		Scanner addressInput = new Scanner("data/address.txt");
		
		String[] maritalStatus = {"Single", "Married"};
		String[] gender = {"Male", "Female", "Unspecified"};
		String[] educationLevel = {"Pre-grad", "High School Grad", "Associate's", "Bachelor's", "Master's", "Doctorate"};
		System.out.println("[");
		for(int i = 0; i < NUM_ENTRIES; i++) {
			System.out.println("\t{");
			System.out.print("\t\tAddress: ");
		}
		
		
	}
}
