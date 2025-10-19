package com.oyunerbabi.hafta4;

import android.os.Bundle;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.google.android.material.textfield.TextInputLayout;


public class MainActivity extends AppCompatActivity {

    TextInputLayout AdLayout, SoyadLayout;
    RadioButton Erkek, Kadin;
    Button GonderButton;
    TextView textView;
    String sonuc, Gender;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });


        AdLayout = findViewById(R.id.AdInput);
        //SoyadLayout = findViewById(R.id.SoyadInput);
        //Erkek = findViewById(R.id.ErkekRadio);
        //Kadin = findViewById(R.id.KadinRadio);
        //GonderButton = findViewById(R.id.ButtonGonder);
        //textView = findViewById(R.id.textView);


        /*
        GonderButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if(Erkek.isChecked()){
                    Gender = "Erkek";
                } else if (Kadin.isChecked())
                {
                    Gender = "Kadın";
                }

                String ad = "";
                String soyad = "";

                if (AdLayout.getEditText() != null)
                    ad = AdLayout.getEditText().getText().toString().trim();

                if (SoyadLayout.getEditText() != null)
                    soyad = SoyadLayout.getEditText().getText().toString().trim();

                sonuc = String.format("Ad: %s\nSoyad: %s\nCinsiyet: %s", ad, soyad, Gender);

                textView.setText(sonuc);
                }
            }
        );

        */


    }
}