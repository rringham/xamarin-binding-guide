//
//  ALViewController.m
//  Alert
//
//  Created by Rob Ringham on 8/3/14.
//  Copyright (c) 2014 Rob Ringham. All rights reserved.
//

#import "ALViewController.h"
#import "AlertKit.h"

@interface ALViewController ()

@end

@implementation ALViewController

- (void)viewDidLoad
{
    [super viewDidLoad];
	// Do any additional setup after loading the view, typically from a nib.
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (IBAction)alertButtonPressed:(id)sender
{
    AlertKit *ak = [[AlertKit alloc] initWithAlertMessage:@"Oh no, somethign alert-worthy has occurred!"];
    [ak alert];
}

@end