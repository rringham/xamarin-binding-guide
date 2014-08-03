//
//  AlertKit.m
//  AlertKit
//
//  Created by Rob Ringham on 8/3/14.
//  Copyright (c) 2014 Rob Ringham. All rights reserved.
//

#import "AlertKit.h"
#import <UIKit/UIKit.h>

@implementation AlertKit

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
                                                       delegate:nil
                                              cancelButtonTitle:@"OK"
                                              otherButtonTitles:nil, nil];
    [alertView show];
}

@end