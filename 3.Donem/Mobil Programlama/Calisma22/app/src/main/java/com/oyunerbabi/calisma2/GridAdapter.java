package com.oyunerbabi.calisma2;

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

public class GridAdapter extends BaseAdapter {
    ArrayList<Integer> images;
    ArrayList<String> texts;
    Context context;

    public GridAdapter(ArrayList<Integer> images, ArrayList<String> texts, Context context){
        this.images = images;
        this.texts = texts;
        this.context = context;
    }

    @Override
    public int getCount() {
        return images.size();
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
        View view = LayoutInflater.from(context).inflate(R.layout.grid, parent, false);
        ImageView imageView = view.findViewById(R.id.imageView3);
        imageView.setImageResource(images.get(position));
        TextView textView = view.findViewById(R.id.textView3);
        textView.setText(texts.get(position));
        return view;
    }


}
