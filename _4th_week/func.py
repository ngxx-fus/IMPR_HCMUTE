import cv2          #sử dụng thư viện xử lí ảnh openCV cho python   
from PIL import Image
import numpy as np  #thư viện toán học

def gray_scale_avg_PILLOW(Original : Image) -> Image:
    #tuple [L:R)
    w, h = Original.size
    # create an image
    gray = Image.new(Original.mode, Original.size)
    # the gray scale processing
    for x in range(w) : 
        for y in range(h):
            localtion = (x,y)
            R, G, B = Original.getpixel( localtion )
            # avg = np.uint8(B/3+G/3+R/3)
            avg = np.uint8((R + G+ B) / 3)
            color = (avg, avg, avg)
            gray.putpixel( localtion, color)
    return gray

def gray_scale_lightness_PILLOW(Original : Image) -> Image:
    #tuple [L:R)
    w, h = Original.size
    # create an image
    gray = Image.new(Original.mode, Original.size)
    # the gray scale processing
    for x in range(w) : 
        for y in range(h):
            localtion = (x,y)
            R, G, B = Original.getpixel( localtion )
            min_val = min(B, G, R)
            max_val = max(B, G, R)
            G_val = np.uint8( (max_val + min_val)/2 )
            color = (G_val, G_val, G_val)
            gray.putpixel( localtion, color)
    return gray

def gray_scale_luminance_PILLOW(Original : Image) -> Image:
    #tuple [L:R)
    w, h = Original.size
    #create an image
    gray = Image.new( Original.mode, Original.size )
    # the gray scale processing
    for x in range(w) : 
        for y in range(h):
            localtion = (x,y)
            R, G, B = Original.getpixel( localtion )[0]
            G_val = np.uint8( 0.3*R + 0.59*G+ 0.11*B)
            color = (G_val, G_val, G_val)
            gray.putpixel( localtion, color)
    return gray


def binary_image_PILLOW(Gray_Img : Image, threshold : np.uint8 = 127 )->Image:
    #get size
    w, h = Gray_Img.size
    #create an image
    res = Image.new( Gray_Img.mode, Gray_Img.size)
    # to binary image processing
    for x in range(w):
        for y in range(h):
            localtion = (x,y)
            R, G, B = Gray_Img.getpixel( localtion )
            if not (R == G and G == B) :
                return Gray_Img
            G_val  = R
            B_val = 0
            if G_val > threshold :
                B_val = 255
            color = (B_val, B_val, B_val)
            res.putpixel( localtion, color)
    return res


