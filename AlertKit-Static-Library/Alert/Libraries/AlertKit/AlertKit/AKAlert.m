//
//  AKAlert.m
//  AlertKit
//
//  Created by Rob Ringham on 8/3/14.
//  Copyright (c) 2014 Rob Ringham. All rights reserved.
//

#import "AKAlert.h"

@implementation AKAlert

- (id)initWithAlertMessage:(NSString *)alertMessage {
    self = [super init];
    if (self) {
        _alertMessage = alertMessage;
    }
    return self;
}

- (void)alert {
    UIAlertView *alertView = [[UIAlertView alloc] initWithTitle:@"Alert!"
                                                        message:self.alertMessage
                                                       delegate:self
                                              cancelButtonTitle:@"OK"
                                              otherButtonTitles:nil, nil];
    [alertView show];
}

#pragma mark - UIAlertViewDelegate

- (void)alertView:(UIAlertView *)alertView clickedButtonAtIndex:(NSInteger)buttonIndex
{
    if (!self.delegate) {
        return;
    }
    
    [self.delegate successfullyAlertedUser];
}

@end