package com.oyunerbabi.calisma;

import android.annotation.SuppressLint;
import android.content.Context;
import android.media.Image;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.ArrayList;

public class gridadapter extends BaseAdapter {
    ArrayList<Integer> resim;
    ArrayList<String> metin;
    Context context;


    public gridadapter(ArrayList<Integer> resim, ArrayList<String> metin,Context context){
        this.resim =resim;
        this.metin = metin;
        this.context = context;
    }


    @Override
    public int getCount() {
        return resim.size();
    }

    @Override
    public Object getItem(int position) {
        return null;
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        @SuppressLint("ViewHolder") View view = LayoutInflater.from(context).inflate(R.layout.gridviewdesign,parent,false);
        ImageView imageView = view.findViewById(R.id.imageView);
        TextView textView = view.findViewById(R.id.textView);
        imageView.setImageResource(resim.get(position));
        textView.setText(metin.get(position));

        return  view;
    }
}
