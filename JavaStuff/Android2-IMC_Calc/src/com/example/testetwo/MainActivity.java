package com.example.testetwo;
import android.os.Bundle;
import android.app.Activity;
import android.app.AlertDialog;
import android.view.Menu;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends Activity {

	TextView text;
	EditText altura;
	EditText peso;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		text = (TextView) findViewById(R.id.text);
		altura = (EditText) findViewById(R.id.editText1);
		peso = (EditText) findViewById(R.id.editText2);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}
	
	public void s(View view){
		//AlertDialog.Builder msg = new AlertDialog.Builder(this);
		
		double p = Double.parseDouble(peso.getText().toString());
		double a = Double.parseDouble(altura.getText().toString());

		String s = Double.toString(p/Math.pow(a,2));
		
		if (p/Math.pow(a,2) <= 16)
			s += " Baixo peso muito grave";
		else if (p/Math.pow(a,2) > 16 && p/Math.pow(a,2) < 16.99)
			s += " Baixo peso grave";
		else if (p/Math.pow(a,2) > 17 && p/Math.pow(a,2) < 18.49)
			s += " Baixo peso";		
		else if (p/Math.pow(a,2) > 18.50 && p/Math.pow(a,2) < 24.99)
			s += " Peso normal";
		else if (p/Math.pow(a,2) > 25 && p/Math.pow(a,2) < 29.99)
			s += " Sobrepeso";
		else if (p/Math.pow(a,2) > 30 && p/Math.pow(a,2) < 34.99)
			s += " Obesidade grau I";
		else if (p/Math.pow(a,2) > 35 && p/Math.pow(a,2) < 39.99)
			s += " Obesidade grau II";
		else if (p/Math.pow(a,2) > 40)
			s += " Obesidade grau III";
		
		text.setText(s);
			
	}

	
}
