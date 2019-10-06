package jsonGen;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Random;
import java.util.Scanner;

public class JSONGenerator {
	
	private static final int NUM_ENTRIES = 234;
	public static void main(String[] args) {
		Scanner addressInput = null;
		try {
			addressInput = new Scanner(new File("data/address.txt"));
		}catch(FileNotFoundException ex) {
			
		}
		
		String[] maritalStatus = {"Single", "Married"};
		String[] gender = {"Male", "Female", "Unspecified"};
		String[] educationLevel = {"Pre-grad", "High School Grad", "Associate's", "Bachelor's", "Master's", "Doctorate"};
		FileWriter writer = null;
		Random rand = new Random();
		try {
			writer = new FileWriter("json.txt");
			writer.write("[\n");
			for(int i = 0; i < NUM_ENTRIES; i++) {
				writer.write("\t{\n");
				writer.write("\t\taddress: ");
				writer.write(addressInput.nextLine() + "\n");
				
				writer.write("\t\tage: ");
				writer.write(rand.nextInt(99) + 1 + "\n");
				
				writer.write("\t\tmaritalStatus: ");
				writer.write(maritalStatus[rand.nextInt(maritalStatus.length)] + "\n");
				
				writer.write("\t\tgender: ");
				writer.write(gender[rand.nextInt(gender.length)] + "\n");
				
				writer.write("\t\teducationLevel: ");
				writer.write(educationLevel[rand.nextInt(educationLevel.length)] + "\n");
				
				writer.write("\t}\n");
				writer.write("\n");
			}
			writer.write("]");
			writer.close();
			addressInput.close();
			
		}catch(IOException ex) {
			System.out.print("Thotto");
		}
	}
}
