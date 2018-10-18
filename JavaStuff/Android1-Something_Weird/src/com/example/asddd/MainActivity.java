package com.example.asddd;

import android.os.Bundle;
import android.app.Activity;
import android.view.*;
import android.widget.Button;
import android.widget.TextView;
import android.util.*;

public class MainActivity extends Activity {

	private Button 	 b;
	private TextView t;
	
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        b = (Button)   findViewById(R.id.b);
        t = (TextView) findViewById(R.id.t);
        setContentView(R.layout.activity_main);

    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }
    
    public void change(View view){
    	b.setText("Ouch!"); // does work
    }
    
    
}
